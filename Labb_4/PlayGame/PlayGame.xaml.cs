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

            MessageBox.Show("Good luck!", /*"Quiz Starts!"*/ "Quiz is still not done! Curses!");

            TheQuizMasterClass iAmTheQuizMaster = new TheQuizMasterClass();
            
            PleaseLoadXML = new XmlDocument();
            PleaseLoadXML.Load(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\SuperHerosQuiz.xml");

            for (int i = 0; i < PleaseLoadXML.DocumentElement.GetElementsByTagName("Statement").Count; i++) {
                
                string questionStatement = PleaseLoadXML.DocumentElement.ChildNodes.Item(i)["Statement"].InnerText.ToString();

                int questionCorrectAnswer = int.Parse(PleaseLoadXML.DocumentElement.ChildNodes.Item(i)["CorrectAnswer"].InnerText);

                string questionAnswerOne = PleaseLoadXML.DocumentElement.ChildNodes.Item(i)["AnswerOne"].InnerText.ToString();

                string questionAnswerTwo = PleaseLoadXML.DocumentElement.ChildNodes.Item(i)["AnswerTwo"].InnerText.ToString();

                string questionAnswerThree = PleaseLoadXML.DocumentElement.ChildNodes.Item(i)["AnswerThree"].InnerText.ToString();

                string[] questionAnswers = new[] {questionAnswerOne, questionAnswerTwo, questionAnswerThree};

                Question loadAQuestion = new Question(questionStatement, questionCorrectAnswer, questionAnswers);

                //iAmTheQuizMaster.NewQuiz.Questions.Add(loadAQuestion);

                //iAmTheQuizMaster.NewQuiz() = new Question();

                //PlayViewsQuestionTextBlock.Text += PleaseLoadXML.DocumentElement.ChildNodes.Item(i)["Statement"].InnerText;
                //PlayViewsQuestionTextBlock.Text += "\n";

            }

        }

        private void ClickedAnswerOne() {



        }

        private void ClickedAnswerTwo() {



        }

        private void ClickedAnswerThree() {



        }

        private void ValidateAnswer() {



        }

        private void ShowNextQuestion() {



        }

        private void PlayAgain() {



        }

    }
}