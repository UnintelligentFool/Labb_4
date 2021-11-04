using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
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
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace Labb_4 {

    public partial class CreateNewQuizQuestions : UserControl {

        private bool _isQuizInstanceAcceptingQuestionsAllready = false;
        private bool _areWeSavingRightNow = false;

        private TheQuizMasterClass _quizHolder;

        public TheQuizMasterClass QuizHolder
        {
            get { return _quizHolder; }
            set { _quizHolder = value; }
        }

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

        private List<saveAs_XML_Blueprint> _aQuestionList;

        public List<saveAs_XML_Blueprint> AQuestionList
        {
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

            InitializeComponent();

            //this.DataContext = new DatacontextMessenger();
            //this.DataContext = new TheQuizMasterClass();

            NewQuestionNumber = 1;

            NewQuizTitle = titleForNewQuiz;
            TextBlockForTitleName.Text = $"{NewQuizTitle}";

            NewQuestionNumberTextBlock.Text = $"Question number: {NewQuestionNumber}";

            AQuestionList = new List<saveAs_XML_Blueprint>();

        }

        private void OpenQuizFile() { //(?????) Utdaterad?



        }

        private void ModifyNewQuiz() {//(?????) Utdaterad?



        }

        private void ClickedNewQuiz() {



        }

        private void ClickedSaveNewQuiz(object sender, RoutedEventArgs e) {

            _areWeSavingRightNow = true;
            AddQuestion();

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

                //MessageBox och denna else skall nog inte spela roll längre sedan jag gjorde att ett svar alltid är checked men bara utifall...
                string missedRadioButtonTitle = "Oppsss!";
                string missedRadioButton = "You forgot to pick a correct answer; now no answer will appear correct for the question in question!";
                MessageBox.Show(missedRadioButton, missedRadioButtonTitle);

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

            }
            else {

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

/*                saveAs_XML_Blueprint creatingQuizFile = new saveAs_XML_Blueprint();
                creatingQuizFile.Statement = newQuestion;
                creatingQuizFile.AnswerOne = answerOneToTheNewQuestion;
                creatingQuizFile.AnswerTwo = answerTwoToTheNewQuestion;
Detta!                creatingQuizFile.AnswerThree = answerThreeToTheNewQuestion;
                creatingQuizFile.CorrectAnswer = correctAnswerToTheNewQuestion;

                AQuestionList.Add(creatingQuizFile);
*/

                XmlSerializer serializer = new XmlSerializer(AQuestionList.GetType(), new XmlRootAttribute("Quiz"));//serializeAListInstead
                
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\");
                //C:\Users\Niklas\AppData\Local\Niklas Eriksson\Labb_4
                
                TextWriter textWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + NewQuizTitle + ".xml");
                
                serializer.Serialize(textWriter, AQuestionList);

                textWriter.Close();

                string doneSavingMessage = "Your quiz \"" + NewQuizTitle + ".xml\" has been saved.\n\nSave location:\n" + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + NewQuizTitle + ".xml";

                string doneSavingTitle = "Quiz Saved";

                MessageBox.Show(doneSavingMessage, doneSavingTitle);

            }

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










/*
 *
https://stackoverflow.com/questions/7502658/how-to-serialize-property-of-type-icollectiont-while-using-entity-framework
 *
private string ConvertClassToXMLString<T>(T classObject) {
                    using (var stream = new MemoryStream()) {
                        var serializer = new DataContractSerializer(classObject.GetType());
                        serializer.WriteObject(stream, classObject);

                        return Encoding.UTF8.GetString(stream.ToArray());
                    }
                }
 *
 */