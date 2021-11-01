using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

namespace Labb_4 {
    /// <summary>
    /// Interaction logic for CreateNewQuizQuestions.xaml
    /// </summary>
    public partial class CreateNewQuizQuestions : UserControl {

        /*
         Kan bara ärva från en klass! D-: Med andra ord, kan inte ärva både från
         "CreateNewQuizTitle" samt "UserControl". Lösningen? Jag får helt enkelt 
         skriva om det och sända title som parameter från "CreateNewQuizTitle"...
         Hoppas det löser det. Får flytta koden från klasserna jag skrivit in i 
         mina UserControl klasser nu, eftersom de skapades när jag skapade 
         UserControls... :-/
        */
        
        //private List<string> _newQuiz;//Behövs den? Använder jag "Quiz" och "Questions" direkt istället, genom TheQuizMasterClass?

        //public List<string> _NewQuiz {
        //    get { return _newQuiz; }
        //    set { _newQuiz = value; }
        //}

        private string _newQuizTitle;

        public string NewQuizTitle
        {
            get { return _newQuizTitle; }
            set { _newQuizTitle = value; }
        }

        private int _newQuestionNumber;

        private int NewQuestionNumber
        {
            get { return _newQuestionNumber; }
            set { _newQuestionNumber = value; }
        }
        
        public CreateNewQuizQuestions(string titleForNewQuiz) {

            InitializeComponent();

            //this.DataContext = new DatacontextMessenger();
            //this.DataContext = new TheQuizMasterClass();

            NewQuestionNumber = 0;

            NewQuizTitle = titleForNewQuiz;
            TextBlockForTitleName.Text = $"{NewQuizTitle}";

            NewQuestionNumberTextBlock.Text = $"Question number: {NewQuestionNumber}";

        }

        private void OpenQuizFile() { //(?????) Utdaterad?



        }

        private void ModifyNewQuiz() {//(?????) Utdaterad?



        }

        private void ClickedNewQuiz() {



        }

        private void ClickedSaveNewQuiz() {



        }

        private void ClickedAddQuestion(object sender, RoutedEventArgs e) {

            AddQuestion();

        }

        private void ClickedSwitchToPlayQuiz() {



        }

        private void ClickedSwitchToEditQuiz() {



        }

        private void QuizNew() {



        }

        private void ValidateAllFieldsFilled() {



        }

        private void AddQuestion() {

            NewQuestionNumber++;
            NewQuestionNumberTextBlock.Text = $"Question number: {NewQuestionNumber}";

            int correctAnswerToTheNewQuestion = 0;

            if (RadioButtonAnswerOne.IsChecked == true) {

                correctAnswerToTheNewQuestion = 1;//Skall jag använda 1 eller 0? Kan vara värt att se på längre fram... Array startar med 0 och list med 1 om jag skall använda det för att ta fram ett värde på det sättet.

            } else if (RadioButtonAnswerTwo.IsChecked == true) {

                correctAnswerToTheNewQuestion = 2;

            } else if (RadioButtonAnswerThree.IsChecked == true) {

                correctAnswerToTheNewQuestion = 3;

            } else {

                //Om tid/tålamod över, ge felmeddelande, kräv att ett val görs... Kanske. Messagebox?
                correctAnswerToTheNewQuestion = 0;

            }
            
            string newQuestion = NewQuestionTextBox.ToString();

            string answerOneToTheNewQuestion = NewAnswerOneTextBox.ToString();
            string answerTwoToTheNewQuestion = NewAnswerTwoTextBox.ToString();
            string answerThreeToTheNewQuestion = NewAnswerThreeTextBox.ToString();

            string[] answersToTheNewQuestion = new string[]
                {answerOneToTheNewQuestion, answerTwoToTheNewQuestion, answerThreeToTheNewQuestion};

            TheQuizMasterClass quizHolder = new TheQuizMasterClass();

            quizHolder.NewQuiz.Title = NewQuizTitle;
            quizHolder.NewQuiz.AddQuestion(newQuestion, correctAnswerToTheNewQuestion, answersToTheNewQuestion);
            //quizHolder.NewQuiz.AddQuestion();

            NewQuestionTextBox.Text = quizHolder.NewQuiz.Title;
            NewQuestionTextBox.Text += "\n" + quizHolder.NewQuiz.Questions.ToString();

            /* private Quiz _newQuiz;

        public Quiz NewQuiz
        {
            get { return _newQuiz; }
            set { _newQuiz = value; }
        } */

        }

        private void NewQuestion() {



        }

        private void SaveNewQuiz() {



        }

        private void SaveSuccessfulFeedback() {



        }

        private void ShowNewQuiz() {



        }

    }
}