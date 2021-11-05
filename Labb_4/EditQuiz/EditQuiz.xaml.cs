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
using System.Xml.Linq;
using Path = System.IO.Path;
using System.Runtime.Serialization;

namespace Labb_4 {

    public partial class EditQuiz : UserControl {

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
/*
            DataSet myDataset = new DataSet();
            myDataset.ReadXml(@Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\DoesThisChangeRoot.xml");//SuperherosNiklasVersion

            EditableDataGrid.ItemsSource = myDataset.Tables[0].DefaultView;
*/
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




            /*
                         OpenFileDialog openAnotherQuiz = new OpenFileDialog();
                        openAnotherQuiz.Filter = "Xml files (*.xml)|*.xml";
                        if (openAnotherQuiz.ShowDialog() == true) {

                            saveAs_XML_Blueprint aNewQuiz = new saveAs_XML_Blueprint();

                            XmlSerializer serializer = new XmlSerializer(aNewQuiz.GetType(), new XmlRootAttribute("Quiz"));

                            //TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + "DoesThisChangeRoot" + ".xml");

                            TextReader textReader = new StreamReader(openAnotherQuiz.FileName);

                            aNewQuiz = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

                            textReader.Close();

                            MessageBox.Show("Deserialization seems to have worked!\nBut how do I check it?");

                            DataSet myNewDataset = new DataSet();
                            myNewDataset.ReadXml(openAnotherQuiz.FileName);//SuperherosNiklasVersion
                            EditableDataGrid.ItemsSource = myNewDataset.Tables[0].DefaultView;

                            ModifyQuiz = openAnotherQuiz.FileName;

             */





            OpenFileDialog openAnotherQuiz = new OpenFileDialog();
            openAnotherQuiz.Filter = "Xml files (*.xml)|*.xml";
            if (openAnotherQuiz.ShowDialog() == true) {

                ANewQuiz = new saveAs_XML_Blueprint();

                XmlSerializer serializer = new XmlSerializer(ANewQuiz.GetType(), new XmlRootAttribute("Quiz"));

                //TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + "DoesThisChangeRoot" + ".xml");

                TextReader textReader = new StreamReader(openAnotherQuiz.FileName);
                
                ANewQuiz = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

                textReader.Close();

                MessageBox.Show("Deserialization seems to have worked!\nBut how do I check it?");

                DataSet myNewDataset = new DataSet();
                myNewDataset.ReadXml(openAnotherQuiz.FileName);//SuperherosNiklasVersion
                EditableDataGrid.ItemsSource = myNewDataset.Tables[0].DefaultView;

                IsTheDatagridEmpty = false;
                
                ModifyQuiz = openAnotherQuiz.FileName;

                /*
                TheQuizMasterClass iWantThoseValues = new TheQuizMasterClass(aNewQuiz.Statement, aNewQuiz.CorrectAnswer, new string[] {aNewQuiz.AnswerOne, aNewQuiz.AnswerTwo, aNewQuiz.AnswerThree});
                iWantThoseValues.NewQuiz.Title = openAnotherQuiz.FileName;
                
                return iWantThoseValues;
                */

                //newQuizStatements

                //(aNewQuiz.Statement, aNewQuiz.CorrectAnswer, new string[] { aNewQuiz.AnswerOne, aNewQuiz.AnswerTwo, aNewQuiz.AnswerThree });
                //Title = openAnotherQuiz.FileName;

                //return ();

            }
            else {

                //return default;

            }



        }

        private void SaveQuizClick(object sender, RoutedEventArgs e) {

            //DataSet currentDataSet = (DataSet)EditableDataGrid.DataContext;
            //currentDataSet.WriteXml(ModifyQuiz, XmlWriteMode.IgnoreSchema);//DatagridWrittenXML.xml

/*            saveAs_XML_Blueprint saveChangesToXML = new saveAs_XML_Blueprint();

            XElement xmlFile = XElement.Load(ModifyQuiz);
            xmlFile.Add(saveChangesToXML);

            xmlFile.Save(ModifyQuiz);
            DataSet anotherDataSet = new DataSet();
            anotherDataSet.ReadXml(ModifyQuiz);
            EditableDataGrid.ItemsSource = anotherDataSet.Tables[0].DefaultView;
*/



            if (IsTheDatagridEmpty == false) {

                //IsTheDatagridEmpty = true;

/*
 
                saveAs_XML_Blueprint saveChangesToXML = new saveAs_XML_Blueprint();

                XElement xmlFile = XElement.Load(ModifyQuiz);
                xmlFile.Add(saveChangesToXML);

                xmlFile.Save(ModifyQuiz);
                DataSet anotherDataSet = new DataSet();
                anotherDataSet.ReadXml(ModifyQuiz);
                EditableDataGrid.ItemsSource = anotherDataSet.Tables[0].DefaultView;
 
 */                

                /*
                saveAs_XML_Blueprint saveChangesToXML = new saveAs_XML_Blueprint();
                saveChangesToXML.Statement = "Hello";
                saveChangesToXML.CorrectAnswer = 2;
                saveChangesToXML.AnswerOne = "World";
                saveChangesToXML.AnswerTwo = "Quiz";
                saveChangesToXML.AnswerThree = "Human";
                */


                XElement xmlFile = XElement.Load(ModifyQuiz);
               // xmlFile.Add(saveChangesToXML);
                
                xmlFile.Save(ModifyQuiz);
                DataSet anotherDataSet = new DataSet();
                anotherDataSet.ReadXml(ModifyQuiz);
                EditableDataGrid.ItemsSource = anotherDataSet.Tables[0].DefaultView;



            }
            else {

                MessageBox.Show("Please load and edit a quiz first, before saving!", "Failed to edit Quiz");

            }



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

















/*


namespace Labb_4 {

    public partial class CreateNewQuizQuestions : UserControl {

        private bool _isQuizInstanceAcceptingQuestionsAllready = false;
        private bool _areWeSavingRightNow = false;

        private TheQuizMasterClass _quizHolder;

        public TheQuizMasterClass QuizHolder {
            get { return _quizHolder; }
            set { _quizHolder = value; }
        }

        private List<saveAs_XML_Blueprint> _aQuestionList;

        public List<saveAs_XML_Blueprint> AQuestionList {
            get { return _aQuestionList; }
            set { _aQuestionList = value; }
        }

        private saveAs_XML_Blueprint _creatingQuizFile = new saveAs_XML_Blueprint();

        public saveAs_XML_Blueprint CreatingQuizFile {
            get { return _creatingQuizFile; }
            set { _creatingQuizFile = value; }
        }

        private int _counterForAQuestionList = 1;

        public int CounterForAQuestionList {

            get { return _counterForAQuestionList; }
            set { _counterForAQuestionList = value; }
        }

        public CreateNewQuizQuestions(string titleForNewQuiz) {

            AQuestionList = new List<saveAs_XML_Blueprint>();

        }

        private void AddQuestion() {

            int correctAnswerToTheNewQuestion = 0;

            if (RadioButtonAnswerOne.IsChecked == true) {

                correctAnswerToTheNewQuestion = 1;

            } else if (RadioButtonAnswerTwo.IsChecked == true) {

                correctAnswerToTheNewQuestion = 2;

            } else if (RadioButtonAnswerThree.IsChecked == true) {

                correctAnswerToTheNewQuestion = 3;

            }

            string newQuestion = NewQuestionTextBox.Text;

            string answerOneToTheNewQuestion = NewAnswerOneTextBox.Text;
            string answerTwoToTheNewQuestion = NewAnswerTwoTextBox.Text;
            string answerThreeToTheNewQuestion = NewAnswerThreeTextBox.Text;

            string[] answersToTheNewQuestion = new string[]
                {answerOneToTheNewQuestion, answerTwoToTheNewQuestion, answerThreeToTheNewQuestion};

            if (_isQuizInstanceAcceptingQuestionsAllready == false) {

                QuizHolder = new TheQuizMasterClass(newQuestion, correctAnswerToTheNewQuestion, answersToTheNewQuestion);

                _isQuizInstanceAcceptingQuestionsAllready = true;

            } else {

                QuizHolder.NewQuiz.Questions.Add(new Question(newQuestion, correctAnswerToTheNewQuestion,
                    answersToTheNewQuestion));

            }

            NewQuestionTextBox.Text = "";
            NewAnswerOneTextBox.Text = "";
            NewAnswerTwoTextBox.Text = "";
            NewAnswerThreeTextBox.Text = "";

            saveAs_XML_Blueprint creatingQuizFile = new saveAs_XML_Blueprint();
            creatingQuizFile.Statement = newQuestion;
            creatingQuizFile.AnswerOne = answerOneToTheNewQuestion;
            creatingQuizFile.AnswerTwo = answerTwoToTheNewQuestion;
            creatingQuizFile.AnswerThree = answerThreeToTheNewQuestion;
            creatingQuizFile.CorrectAnswer = correctAnswerToTheNewQuestion;

            AQuestionList.Add(creatingQuizFile);

            if (_areWeSavingRightNow == true) {

                _areWeSavingRightNow = false;

                XmlSerializer serializer = new XmlSerializer(AQuestionList.GetType(), new XmlRootAttribute("Quiz"));

                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\");
                
                TextWriter textWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + NewQuizTitle + ".xml");

                serializer.Serialize(textWriter, AQuestionList);

                textWriter.Close();


                string doneEditingMessage = "Your quiz has been edited.";

                string doneEditingTitle = "Quiz Edited";

                MessageBox.Show(doneEditingMessage, doneEditingTitle);

            }

        }

    }

}

*/