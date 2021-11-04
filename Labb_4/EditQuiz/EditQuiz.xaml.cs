using System;
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
using Path = System.IO.Path;

namespace Labb_4 {

    public partial class EditQuiz : UserControl {

        //DataSet _myDataset = new DataSet();

        //public DataSet MyDataSet {
        //    get { return _myDataset; }
        //    set { _myDataset = value; }
        //}

        private string _activeQuiz;

        public string ActiveQuiz //(???) //Kanske kolla med TheQuizzMasterClass?
        {
            get { return _activeQuiz; }
            set { _activeQuiz = value; }
        }

        public EditQuiz() {

            InitializeComponent();
            DataSet myDataset = new DataSet();
            myDataset.ReadXml(@Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\DoesThisChangeRoot.xml");//SuperherosNiklasVersion

            EditableDataGrid.ItemsSource = myDataset.Tables[0].DefaultView;

            //EditableDataGrid

        }

        private void LoadQuizClick(object sender, RoutedEventArgs e) {
            /*
                        //XAML: Command = "Open" //Kanske
                        OpenFileDialog openAnotherQuiz = new OpenFileDialog();
                        openAnotherQuiz.Filter = "Xml files (*.xml)|*.xml";
                        if (openAnotherQuiz.ShowDialog() == true) {

                            //FileStream fileStream = new FileStream(openAnotherQuiz.FileName, FileMode.Open);

                            //Quiz aNewQuiz = new Quiz();

                            saveAs_XML_Blueprint aNewQuiz = new saveAs_XML_Blueprint();

                            XmlSerializer serializer = new XmlSerializer(aNewQuiz.GetType());

                            TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + "Valhalla" + ".xml");

                            //TextReader textReader = new StreamReader();

                            aNewQuiz = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

                            textReader.Close();

                            //string hello = aNewQuiz.Questions.Count().ToString();

                            //MessageBox.Show(hello);

                            //XElement quizFile = XElement.Load(@"quiz.xml");

                        }
            */



            /*
            OpenFileDialog openAnotherQuiz = new OpenFileDialog();
            openAnotherQuiz.Filter = "Xml files (*.xml)|*.xml";
            if (openAnotherQuiz.ShowDialog() == true) {

                saveAs_XML_Blueprint aNewQuiz = new saveAs_XML_Blueprint();

                //FillMeUpWithXML aNewQuiz = new FillMeUpWithXML();

                XmlSerializer serializer = new XmlSerializer(aNewQuiz.GetType(), new XmlRootAttribute("Quiz"));

                TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + "DoesThisChangeRoot" + ".xml");

                //TextReader textReader = new StreamReader(Environment.GetFolderPath();

                aNewQuiz = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

                //aNewQuiz = (FillMeUpWithXML)serializer.Deserialize(textReader);

                textReader.Close();

                //MessageBox.Show(hello);
                


            } */




            OpenFileDialog openAnotherQuiz = new OpenFileDialog();
            openAnotherQuiz.Filter = "Xml files (*.xml)|*.xml";
            if (openAnotherQuiz.ShowDialog() == true) {

                saveAs_XML_Blueprint aNewQuiz = new saveAs_XML_Blueprint();

                XmlSerializer serializer = new XmlSerializer(aNewQuiz.GetType(), new XmlRootAttribute("Quiz"));

                TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + "DoesThisChangeRoot" + ".xml");
                
                aNewQuiz = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

                textReader.Close();

                MessageBox.Show("Deserialization seems to have worked!\nBut how do I check it?\nAlso, still need to specify file to load...");

                DataSet myNewDataset = new DataSet();
                myNewDataset.ReadXml(@Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\WeAreVikings.xml");//SuperherosNiklasVersion
                EditableDataGrid.ItemsSource = myNewDataset.Tables[0].DefaultView;

            }



        }

        private void SaveQuizClick() {



        }

        private void ClickedSwitchToCreateQuiz() {



        }

        private void ClickedSwitchToPlayQuiz() {



        }

        private void LoadSelectedQuizFile() {

            //DataSet myDataset = new DataSet();
            //myDataset.ReadXml(@Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" +  + ".xml");

            //EditableDataGrid.ItemsSource = myDataset.Tables[0].DefaultView;

        }

        private void ShowQuizFile() {

            LoadQuiz showTheQuiz = new LoadQuiz();
            
            //EditableDataGrid = new BindableCollection<QuiICollection>(ICollection());

        }

        private void SaveQuizFile() {



        }

    }
}