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

            /*foreach (var question in QuizHolder.NewQuiz.Questions) {

                NewQuestionTextBox.Text += question.Answers[question.CorrectAnswer - 1];
                //NewQuestionTextBox.Text = question.Answers[question.CorrectAnswer - 1];

            }*/

            /*            foreach (var question in quizHolder.NewQuiz.Questions) {

                            NewQuestionTextBox.Text += question.Statement;
                            NewQuestionTextBox.Text += question.Answers[0];
                            NewQuestionTextBox.Text += question.CorrectAnswer;

                        } */

            //quizHolder.NewQuiz.Title = NewQuizTitle;
            //quizHolder.NewQuiz.AddQuestion(newQuestion, correctAnswerToTheNewQuestion, answersToTheNewQuestion);
            //quizHolder.NewQuiz.AddQuestion();

            //NewQuestionTextBox.Text = quizHolder.NewQuiz.Title;
            //NewQuestionTextBox.Text += "\n" + quizHolder.NewQuiz.Questions;

            /* private Quiz _newQuiz;

        public Quiz NewQuiz
        {
            get { return _newQuiz; }
            set { _newQuiz = value; }
        } */

            saveAs_XML_Blueprint creatingQuizFile = new saveAs_XML_Blueprint();
            creatingQuizFile.Statement = newQuestion;
            creatingQuizFile.AnswerOne = answerOneToTheNewQuestion;
            creatingQuizFile.AnswerTwo = answerTwoToTheNewQuestion;
            creatingQuizFile.AnswerThree = answerThreeToTheNewQuestion;
            creatingQuizFile.CorrectAnswer = correctAnswerToTheNewQuestion;

            AQuestionList.Add(creatingQuizFile);

            if (_areWeSavingRightNow == true) {

                _areWeSavingRightNow = false;

                //QuizHolder.NewQuiz.Title.ToString();

                //List<Question> useListForConversion = QuizHolder.NewQuiz.Questions.ToList();

                /* List<Quiz> serializeAListInstead = new List<Quiz>();
                foreach (var question in QuizHolder.NewQuiz.Questions) {

                    serializeAListInstead.Add(question);

                } */

                /*                 //Fungerar för att skapa fil men bristfällig
                                 List<List<string>> serializeAListInstead = new List<List<string>>();
                                 foreach (var question in QuizHolder.NewQuiz.Questions) {

                                     List<string> listInsideList = new List<string>();

                                    //listInsideList.Add(QuizHolder.NewQuiz.Title);
                                    listInsideList.Add( question.Statement);
                                    listInsideList.Add(question.CorrectAnswer.ToString());
                                    listInsideList.Add(question.Answers[0]);
                                    listInsideList.Add(question.Answers[1]);
                                    listInsideList.Add(question.Answers[2]);

                                    serializeAListInstead.Add(listInsideList);

                                }
                */
                /*List<string[]> newQuizList = new List<string[]>();

                 foreach (var question in QuizHolder.NewQuiz.Questions) {

                    string[,] Question_ = new string[6,6];
                    Question_[0] = question.Statement;
                     = question.CorrectAnswer;
                     = question.Answers[0];
                     = question.Answers[1];
                     = question.Answers[2];

               } */

                //Dictionary<string, string> newQuizDictionary = new Dictionary<string, string>();
                //List<Dictionary<>> listOfDictionaries = new List<Dictionary<>>();

                /* ListDictionary newQuizListDictionary = new ListDictionary();

                foreach (var question in QuizHolder.NewQuiz.Questions) {

                    Dictionary<string, string> newQuizDictionary = new Dictionary<string, string>();
                   newQuizDictionary.Add("Statement", question.Statement);
                    newQuizDictionary.Add("CorrectAnswer", question.CorrectAnswer.ToString());
                    newQuizDictionary.Add("AnswerOne", question.Answers[0]);
                    newQuizDictionary.Add("AnswerTwo", question.Answers[1]);
                    newQuizDictionary.Add("AnswerThree", question.Answers[2]);

                    newQuizListDictionary.Add(newQuizDictionary);

               } */

                /* ListDictionary newQuizListDictionary = new ListDictionary();

                foreach (var question in QuizHolder.NewQuiz.Questions) {

                    Dictionary<string, string> newQuizDictionary = new Dictionary<string, string>();
                    newQuizDictionary.Add("Statement", question.Statement);
                    newQuizDictionary.Add("CorrectAnswer", question.CorrectAnswer.ToString());
                    newQuizDictionary.Add("AnswerOne", question.Answers[0]);
                    newQuizDictionary.Add("AnswerTwo", question.Answers[1]);
                    newQuizDictionary.Add("AnswerThree", question.Answers[2]);

                    newQuizListDictionary.Add(newQuizDictionary);

                } */

                                 //Fungerar för att skapa fil men bristfällig xml utan bra namngivning... But if it works it works and I DON'T CARE ANYMORE AFTER 100+ HOURS OF TRYING TO GET IT TO WORK!
/*                                 List<List<string>> aQuestionList = new List<List<string>>();
                                 foreach (var question in QuizHolder.NewQuiz.Questions) {

                                     List<string> aQuestion = new List<string>();

                                    //listInsideList.Add(QuizHolder.NewQuiz.Title);
                                    aQuestion.Add( question.Statement);
                                    aQuestion.Add(question.CorrectAnswer.ToString());
                                    aQuestion.Add(question.Answers[0]);
                                    aQuestion.Add(question.Answers[1]);
                                    aQuestion.Add(question.Answers[2]);

                                    aQuestionList.Add(aQuestion);

                                }
*/

/* Lösningen?                IConfuseMyself creatingQuizFile = new IConfuseMyself();
                creatingQuizFile.Statement = newQuestion;
                creatingQuizFile.AnswerOne = answerOneToTheNewQuestion;
                creatingQuizFile.AnswerTwo = answerTwoToTheNewQuestion;
                creatingQuizFile.AnswerThree = answerThreeToTheNewQuestion;
                creatingQuizFile.CorrectAnswer = correctAnswerToTheNewQuestion;
*/

/*                saveAs_XML_Blueprint creatingQuizFile = new saveAs_XML_Blueprint();
                creatingQuizFile.Statement = newQuestion;
                creatingQuizFile.AnswerOne = answerOneToTheNewQuestion;
                creatingQuizFile.AnswerTwo = answerTwoToTheNewQuestion;
Detta!                creatingQuizFile.AnswerThree = answerThreeToTheNewQuestion;
                creatingQuizFile.CorrectAnswer = correctAnswerToTheNewQuestion;

                AQuestionList.Add(creatingQuizFile);
*/


                //foreach (var question in QuizHolder.NewQuiz.Questions) {

                //saveAs_XML_Blueprint creatingQuizFile = new saveAs_XML_Blueprint();

                //CreatingQuizFile = new saveAs_XML_Blueprint[5];

                //CreatingQuizFile[CounterForAQuestionList].Statement = newQuestion;
                //CreatingQuizFile[CounterForAQuestionList].AnswerOne = answerOneToTheNewQuestion;
                //CreatingQuizFile[CounterForAQuestionList].AnswerTwo = answerTwoToTheNewQuestion;
                //CreatingQuizFile[CounterForAQuestionList].AnswerThree = answerThreeToTheNewQuestion;
                //CreatingQuizFile[CounterForAQuestionList].CorrectAnswer = correctAnswerToTheNewQuestion;

                //AQuestionList.Add(CreatingQuizFile);

                //CounterForAQuestionList++;

                //}


                //List<List<string>> listWithLists = new List<List<string>>();
                //foreach (var question in QuizHolder.NewQuiz.Questions) {

                //    //List<List> listWithLists = new List<List>();

                //    List<string> aStatement = new List<string>();
                //    List<string> aCorrectAnswer = new List<string>();
                //    List<string> aAnswerOne = new List<string>();
                //    List<string> aAnswerTwo = new List<string>();
                //    List<string> aAnswerThree = new List<string>();

                //    aStatement.Add(question.Statement);
                //    aCorrectAnswer.Add(question.CorrectAnswer.ToString());
                //    aAnswerOne.Add(question.Answers[0]);
                //    aAnswerTwo.Add(question.Answers[1]);
                //    aAnswerThree.Add(question.Answers[2]);

                //    listWithLists.Add(aStatement);
                //    listWithLists.Add(aCorrectAnswer);
                //    listWithLists.Add(aAnswerOne);
                //    listWithLists.Add(aAnswerTwo);
                //    listWithLists.Add(aAnswerThree);

                //}


                /*
                List<Dictionary<string, string>> newQuizListDictionary = new List<Dictionary<string, string>>();
                
                foreach (var question in QuizHolder.NewQuiz.Questions) {

                    Dictionary<string, string> newQuizDictionary = new Dictionary<string, string>();
                    newQuizDictionary.Add("Statement", question.Statement);
                    newQuizDictionary.Add("CorrectAnswer", question.CorrectAnswer.ToString());
                    newQuizDictionary.Add("AnswerOne", question.Answers[0].ToString());
                    newQuizDictionary.Add("AnswerTwo", question.Answers[1].ToString());
                    newQuizDictionary.Add("AnswerThree", question.Answers[2].ToString());

                    newQuizListDictionary.Add(newQuizDictionary);

                }
                */

                //Let's do it!!!

                //bool iWantToHelpToo = true;
                //TheQuizMasterClass letUsHelpSavingWithoutICollectionInterference = new TheQuizMasterClass(iWantToHelpToo, newQuestion, correctAnswerToTheNewQuestion, answersToTheNewQuestion);

                //MasterSaveHelper saveWitHelpers = new MasterSaveHelper(newQuestion, correctAnswerToTheNewQuestion, answersToTheNewQuestion);

                //WORKS                XmlSerializer serializer = new XmlSerializer(aQuestionList.GetType());//serializeAListInstead

                XmlSerializer serializer = new XmlSerializer(AQuestionList.GetType());//serializeAListInstead

                //TextWriter textWriter = new StreamWriter("C:\\Users\\Niklas\\Desktop\\.NET - Utvecklare\\C# .NET21\\Labb 4\\Quiz frågor\\" + NewQuizTitle + ".xml");

                //TextWriter textWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Failure of a Quiz\\" + NewQuizTitle + ".xml");


                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\");
                //C:\Users\Niklas\AppData\Local\Niklas Failure of a Quiz
                //C:\Users\Niklas\AppData\Local\Niklas Eriksson\Labb_4

                //string helpingWritingLink = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString();

                TextWriter textWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + NewQuizTitle + ".xml");
                
                serializer.Serialize(textWriter, AQuestionList);//aQuestionList

                textWriter.Close();

                string doneSavingMessage = "Your quiz \"" + NewQuizTitle + ".xml\" has been saved.\n\nSave location:\n" + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + NewQuizTitle + ".xml";

                string doneSavingTitle = "Quiz Saved";

                MessageBox.Show(doneSavingMessage, doneSavingTitle);

                //string helpMe = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + NewQuizTitle + ".xml";

                //MessageBox.Show(helpMe);

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