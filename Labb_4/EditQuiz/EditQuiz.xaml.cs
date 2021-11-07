using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Xml.Linq;
using Path = System.IO.Path;
using System.Runtime.Serialization;
using System.Xml;
using System.Collections.ObjectModel;

namespace Labb_4 {

    public partial class EditQuiz : UserControl {

        private XmlDocument _pleaseLoadXML = new XmlDocument();

        public XmlDocument PleaseLoadXML {
            get { return _pleaseLoadXML; }
            set { _pleaseLoadXML = value; }
        }

        private DataSet myNewDataset;

        private DataTable _datagridToSave = new DataTable();

        public DataTable DatagridToSave {
            get { return _datagridToSave; }
            set { _datagridToSave = value; }
        }

        private bool _isTheDatagridEmpty = true;

        public bool IsTheDatagridEmpty
        {
            get { return _isTheDatagridEmpty; }
            set { _isTheDatagridEmpty = value; }
        }
        
        private saveAs_XML_Blueprint _aNewQuiz = new saveAs_XML_Blueprint();

        public saveAs_XML_Blueprint ANewQuiz {
            get { return _aNewQuiz; }
            set { _aNewQuiz = value; }
        }

        private string _modifyQuiz;

        public string ModifyQuiz
        {
            get { return _modifyQuiz; }
            set { _modifyQuiz = value; }
        }

        private string _activeQuiz;

        public string ActiveQuiz
        {
            get { return _activeQuiz; }
            set { _activeQuiz = value; }
        }

        public EditQuiz() {

            InitializeComponent();

        }

        private void LoadQuizClick(object sender, RoutedEventArgs e) {

            OpenFileDialog openAnotherQuiz = new OpenFileDialog();
            openAnotherQuiz.Filter = "Xml files (*.xml)|*.xml";
            if (openAnotherQuiz.ShowDialog() == true) {

                ANewQuiz = new saveAs_XML_Blueprint();

                XmlSerializer serializer = new XmlSerializer(ANewQuiz.GetType(), new XmlRootAttribute("Quiz"));

                TextReader textReader = new StreamReader(openAnotherQuiz.FileName);
                
                ANewQuiz = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

                textReader.Close();

                MessageBox.Show("Deserialization seems to have worked!\nBut how do I check it?");

                myNewDataset = new DataSet();
                myNewDataset.ReadXml(openAnotherQuiz.FileName);
                EditableDataGrid.ItemsSource = myNewDataset.Tables[0].DefaultView;

                IsTheDatagridEmpty = false;
                
                ModifyQuiz = openAnotherQuiz.FileName;
                
            }
            else {

            }

        }

        private void SaveQuizClick(object sender, RoutedEventArgs e) {

            if (IsTheDatagridEmpty == false) {

                EditableDataGrid.ItemsSource = myNewDataset.Tables[0].DefaultView;

                saveAs_XML_Blueprint editingQuizFile = new saveAs_XML_Blueprint();

                List<saveAs_XML_Blueprint> editingQuizList = new List<saveAs_XML_Blueprint>();
                
                //Kopierar en rad till alla rader! Nästan där men samtidigt så långt bort....
                for (int i = 0; i < EditableDataGrid.Items.Count; i++) {

                    DataRowView datagridRow = EditableDataGrid.SelectedItem as DataRowView;

                    if (datagridRow != null) {

                        //SelectedCells gör att det blir samma hela tiden... -.-
                        editingQuizFile.Statement = datagridRow[0].ToString();
                        editingQuizFile.AnswerOne = datagridRow[1].ToString();
                        editingQuizFile.AnswerTwo = datagridRow[2].ToString();
                        editingQuizFile.AnswerThree = datagridRow[3].ToString();

                        var beingConverted = datagridRow[4].ToString();//Upset person: Who let that Age of Empires II monk in?!
                        int conversionComplete = int.Parse(beingConverted);//Now calm person: Let us pray to the lord almighty.

                        editingQuizFile.CorrectAnswer += conversionComplete;

                        editingQuizList.Add(editingQuizFile);

                    }

                }

                XmlSerializer serializer = new XmlSerializer(editingQuizList.GetType(), new XmlRootAttribute("Quiz"));

                TextWriter textWriter = new StreamWriter(ModifyQuiz);

                serializer.Serialize(textWriter, editingQuizList);

                textWriter.Close();


                string doneSavingMessage = "Your quiz has been edited.";

                string doneSavingTitle = "Quiz Edited";

                MessageBox.Show(doneSavingMessage, doneSavingTitle);

            } else {

                MessageBox.Show("Please load and edit a quiz first, before saving!", "Failed to edit Quiz");

            }

        }
        
        private void ShowQuizFile() {

            LoadQuiz showTheQuiz = new LoadQuiz();

        }

        public void AddData() {
        
        }

    }
}