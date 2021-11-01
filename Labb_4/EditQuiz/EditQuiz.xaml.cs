using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for EditQuiz.xaml
    /// </summary>
    public partial class EditQuiz : UserControl {

        private string _activeQuiz;

        public string ActiveQuiz //(???) //Kanske kolla med TheQuizzMasterClass?
        {
            get { return _activeQuiz; }
            set { _activeQuiz = value; }
        }

        public EditQuiz() {

            InitializeComponent();

        }

        private void LoadQuizClick() {



        }

        private void SaveQuizClick() {



        }

        private void ClickedSwitchToCreateQuiz() {



        }

        private void ClickedSwitchToPlayQuiz() {



        }

        private void LoadSelectedQuizFile() {



        }

        private void ShowQuizFile() {

            LoadQuiz showTheQuiz = new LoadQuiz();
            
            //EditableDataGrid = new BindableCollection<QuiICollection>(ICollection());

        }

        private void SaveQuizFile() {



        }

    }
}