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
        
        private List<string> _newQuiz;//Behövs den? Använder jag "Quiz" och "Questions" direkt istället, genom TheQuizMasterClass?

        public List<string> _NewQuiz {
            get { return _newQuiz; }
            set { _newQuiz = value; }
        }

        public CreateNewQuizQuestions() {
            InitializeComponent();
        }

        private void OpenQuizFile() { //(?????) Utdaterad?



        }

        private void ModifyNewQuiz() {//(?????) Utdaterad?



        }

        private void ClickedNewQuiz() {



        }

        private void ClickedSaveNewQuiz() {



        }

        private void ClickedAddQuestion() {



        }

        private void ClickedSwitchToPlayQuiz() {



        }

        private void ClickedSwitchToEditQuiz() {



        }

        private void NewQuiz() {



        }

        private void ValidateAllFieldsFilled() {



        }

        private void AddQuestion() {



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