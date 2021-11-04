using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4 {
    
    public class SaveNewQuizHelper : TheQuizMasterClass {

        private string[] _questions;

        public string[] Questions {
            get { return _questions; }
            set { _questions = value; }
        }

        private string _title;

        public string SaveHelperTitle {
            get { return _title; }
            set { _title = value; }
        }

        public SaveNewQuizHelper() {
            
        }

        public SaveNewQuizHelper(string statement, int correctAnswer, params string[] answers) {

            string becomeString = correctAnswer.ToString();

            string answerOne = answers[0];

            string answerTwo = answers[1];

            string answerThree = answers[2];

            //string questionToBeAdded = new string(statement, becomeString, answerOne, answerTwo, answerThree);

            string[] questionToBeAdded = new string[] { statement, becomeString, answerOne, answerTwo, answerThree };

            Questions = new string[5];

            Questions = questionToBeAdded;

            SaveNewQuestionHelper pleaseWork = new SaveNewQuestionHelper(statement, becomeString, questionToBeAdded);

        }

        public void AddQuestion() {

            

        }

    }
}