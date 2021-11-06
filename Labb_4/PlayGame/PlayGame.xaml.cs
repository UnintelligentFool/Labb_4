using System;
using System.Collections.Generic;
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
using System.Xml;
using System.Xml.Serialization;
using Labb_4;

namespace Labb_4 {

    public partial class PlayGame : UserControl {

        private XmlDocument _pleaseLoadXML;

        public XmlDocument PleaseLoadXML {
            get { return _pleaseLoadXML; }
            set { _pleaseLoadXML = value; }
        }

        private saveAs_XML_Blueprint _quizLoader;

        public saveAs_XML_Blueprint QuizLoader
        {
            get { return _quizLoader; }
            set { _quizLoader = value; }
        }

        private int _questionNumberCounter = 1;

        public int QuestionNumberCounter {
            get { return _questionNumberCounter; }
            set { _questionNumberCounter = value; }
        }

        private int _totalNumberOfQuestions;

        public int TotalNumberOfQuestions {
            get { return _totalNumberOfQuestions; }
            set { _totalNumberOfQuestions = value; }
        }

        private int _numberOfCorrectAnswers = 0;

        public int NumberOfCorrectAnswers {
            get { return _numberOfCorrectAnswers; }
            set { _numberOfCorrectAnswers = value; }
        }

        public PlayGame() {
            InitializeComponent();

            QuestionNumberTextBlock.Text = "Question:\n" + QuestionNumberCounter;

            CorrectAnswersNumberTextBlock.Text = "Correct answers:\n" + NumberOfCorrectAnswers;

            QuizLoader = new saveAs_XML_Blueprint();

            //saveAs_XML_Blueprint QuizLoader = new saveAs_XML_Blueprint();

            XmlSerializer serializer = new XmlSerializer(QuizLoader.GetType(), new XmlRootAttribute("Quiz"));

            //TextReader textReader = new StreamReader("OriginalQuizFile.xml");

            TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\SuperHerosQuiz.xml");

            //TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\SuperHerosQuiz.xml");

            //QuizLoader = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);
            QuizLoader = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

            textReader.Close();

            MessageBox.Show("Good luck!", "Quiz Starts!");

            TheQuizMasterClass iAmTheQuizMaster = new TheQuizMasterClass();

            /*            foreach (var question in QuizLoader) {

                            Question loadAQuestion = new Question(QuizLoader.Statement, QuizLoader.CorrectAnswer, new string[] {QuizLoader.AnswerOne, QuizLoader.AnswerTwo, QuizLoader.AnswerThree});

                            iAmTheQuizMaster.NewQuiz.Questions.Add(loadAQuestion);

                        }
            */

            /*
                        //Visar en Question och allting i samma string
                        PleaseLoadXML = new XmlDocument();
                        PleaseLoadXML.Load(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\SuperHerosQuiz.xml");

                        foreach (XmlNode node in PleaseLoadXML.DocumentElement.ChildNodes) {

                            PlayViewsQuestionTextBlock.Text = node.InnerText;

                        }
            */

            /*
                        //Visar ALLT i xml-filen i en låååååång string.
                        PleaseLoadXML = new XmlDocument();
                        PleaseLoadXML.Load(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\SuperHerosQuiz.xml");

                        foreach (XmlNode node in PleaseLoadXML) {

                            PlayViewsQuestionTextBlock.Text = node.InnerText;

                        }
            */

            /*
                        //Hämtar ett specifikt värde! (Får ändra, sätta in det i loopen, göra om.)
                        PleaseLoadXML = new XmlDocument();
                        PleaseLoadXML.Load(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\SuperHerosQuiz.xml");

                        foreach (XmlNode node in PleaseLoadXML.DocumentElement.ChildNodes.Item(0)["AnswerOne"]) {

                            PlayViewsQuestionTextBlock.Text = node.InnerText;

                        }

                        //XmlNode node = doc.DocumentElement.SelectSingleNode("/book/title");
                        //node.Attributes["theattributename"]?.InnerText
            */

            PleaseLoadXML = new XmlDocument();
            PleaseLoadXML.Load(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\SuperHerosQuiz.xml");

            PlayViewsQuestionTextBlock.Text = PleaseLoadXML.DocumentElement.ChildNodes.Item(0)["AnswerOne"].InnerText;

        }

        private void Play() {



        }

        private void ClickedAnswerOne() {



        }

        private void ClickedAnswerTwo() {



        }

        private void ClickedAnswerThree() {



        }

        private void ClickedSwitchToCreateQuiz() {



        }

        private void ClickedSwitchToEditQuiz() {



        }

        private void ValidateAnswer() {



        }

        private void ShowNextQuestion() {



        }

        private void PlayAgain() {



        }

    }
}
















/*
//https://stackoverflow.com/questions/642293/how-do-i-read-and-parse-an-xml-file-in-c
XmlDocument doc = new XmlDocument();
doc.Load("c:\\temp.xml");

foreach (XmlNode node in doc.DocumentElement.ChildNodes) {

    string text = node.InnerText; //or loop through its children as well

}
*/