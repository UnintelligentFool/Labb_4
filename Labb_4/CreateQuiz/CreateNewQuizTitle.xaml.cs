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

        private void CreateTheQuizQuestions(string newQuizTitle) {//void enligt klassdiagram



        }

        private void CreateQuizQuestionsButton_Clicked(object sender, RoutedEventArgs e) {
            DataContext = new CreateNewQuizQuestions();
        }
    }
}