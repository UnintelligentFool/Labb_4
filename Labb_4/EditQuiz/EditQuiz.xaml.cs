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

namespace Labb_4 {

    public partial class EditQuiz : UserControl {

        private string _activeQuiz;

        public string ActiveQuiz //(???) //Kanske kolla med TheQuizzMasterClass?
        {
            get { return _activeQuiz; }
            set { _activeQuiz = value; }
        }

        public EditQuiz() {

            InitializeComponent();
            DataSet myDataset = new DataSet();
            myDataset.ReadXml(@Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\IHaveAchievedVictoryOverCreatingTheQuizFunctionality.xml");//SuperherosNiklasVersion

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

                TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" +  + ".xml");

                aNewQuiz = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

                textReader.Close();

                //string hello = aNewQuiz.Questions.Count().ToString();

                //MessageBox.Show(hello);

                //XElement quizFile = XElement.Load(@"quiz.xml");

            }
*/
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