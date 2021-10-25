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
    /// Interaction logic for PlayGame.xaml
    /// </summary>
    public partial class PlayGame : UserControl {

        private int _questionNumberCounter;

        public int QuestionNumberCounter {
            get { return _questionNumberCounter; }
            set { _questionNumberCounter = value; }
        }

        private int _totalNumberOfQuestions;

        public int TotalNumberOfQuestions {
            get { return _totalNumberOfQuestions; }
            set { _totalNumberOfQuestions = value; }
        }

        private int _numberOfCorrectAnswers;

        public int NumberOfCorrectAnswers {
            get { return _numberOfCorrectAnswers; }
            set { _numberOfCorrectAnswers = value; }
        }

        public PlayGame() {
            InitializeComponent();
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