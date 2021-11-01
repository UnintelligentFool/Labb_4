using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4 {
    class TheQuizMasterClass {

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

        public TheQuizMasterClass()
        {
            


        }

        private void SetActiveQuiz() {



        }

    }
}
