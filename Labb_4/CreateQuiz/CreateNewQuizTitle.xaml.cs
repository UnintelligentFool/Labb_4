using System;
using System.Collections.Generic;
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
    /// Interaction logic for CreateNewQuizTitle.xaml
    /// </summary>
    public partial class CreateNewQuizTitle : UserControl {

        private string _newQuizTitle;

        public string NewQuizTitle {
            get { return _newQuizTitle; }
            set { _newQuizTitle = value; }
        }

        public CreateNewQuizTitle() {

            InitializeComponent();

        }

        private string SetNewQuizTitle() {

            //Skall den returnera eller ta in en string alternativt bådadera?

            return ("");

        }

        private void ClickedCreateQuestions(string newQuizTitle) {



        }

        private void ClickedSwitchToPlayQuiz() {



        }

        private void ClickedSwitchToEditQuiz() {



        }

        private void CreateTheQuizQuestions() {//(string newQuizTitle) {//void enligt klassdiagram

            //string titleForNewQuiz = TitleTextBox.Text;

            string titleForNewQuiz = TitleTextBox.Text;

            //////
            //https://stackoverflow.com/questions/6219454/efficient-way-to-remove-all-whitespace-from-string
            titleForNewQuiz = string.Join("", titleForNewQuiz.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            //////

            if (!string.IsNullOrEmpty(titleForNewQuiz)) {

                App.Current.MainWindow.DataContext = new CreateNewQuizQuestions(titleForNewQuiz);

            }
            else {

                titleForNewQuiz = "New_Quiz";

                App.Current.MainWindow.DataContext = new CreateNewQuizQuestions(titleForNewQuiz);

            }

        }

        private void CreateQuizQuestionsButton_Clicked(object sender, RoutedEventArgs e) {
            
            //App.Current.MainWindow.DataContext = new CreateNewQuizQuestions();

            CreateTheQuizQuestions();

        }
    }
}