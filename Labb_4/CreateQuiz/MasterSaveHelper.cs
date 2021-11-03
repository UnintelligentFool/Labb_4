using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4 {
    public class MasterSaveHelper {

        private SaveNewQuizHelper _saveNewQuizHelpers;

        public SaveNewQuizHelper SaveNewQuizHelpers {
            get { return _saveNewQuizHelpers; }
            set { _saveNewQuizHelpers = value; }
        }

        public MasterSaveHelper() {
            
        }

        public MasterSaveHelper(string statement, int correctAnswer, params string[] answers) {
            
            SaveNewQuizHelpers = new SaveNewQuizHelper(statement, correctAnswer, answers);
            
        }

    }
}