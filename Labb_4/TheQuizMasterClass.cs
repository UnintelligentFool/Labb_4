using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4 {
    public class TheQuizMasterClass {

        private Quiz _activeQuiz;

        public Quiz ActiveQuiz
        {
            get { return _activeQuiz; }
            set { _activeQuiz = value; }
        }

        private Quiz _newQuiz;

        public Quiz NewQuiz {
            get { return _newQuiz; }
            set { _newQuiz = value; }
        }

        //private SaveNewQuizHelper _saveNewQuizHelpers;

        //public SaveNewQuizHelper SaveNewQuizHelpers {
        //    get { return _saveNewQuizHelpers; }
        //    set { _saveNewQuizHelpers = value; }
        //}

        public TheQuizMasterClass()
        {
            


        }

        public TheQuizMasterClass(string statement, int correctAnswer, params string[] answers) {

            //Quiz NewQuiz = new Quiz();
            NewQuiz = new Quiz();
            NewQuiz.AddQuestion(statement, correctAnswer, answers);

            //SaveNewQuizHelpers = new SaveNewQuizHelper();
            //SaveNewQuizHelpers.AddQuestion(statement, correctAnswer, answers);

        }

        //public TheQuizMasterClass(bool areWeHelping, string statement, int correctAnswer, params string[] answers) {

        //    areWeHelping = true;

        //    SaveNewQuizHelpers = new SaveNewQuizHelper();
        //    SaveNewQuizHelpers.AddQuestion(statement, correctAnswer, answers);

        //}

        private void SetActiveQuiz() {



        }

    }
}
