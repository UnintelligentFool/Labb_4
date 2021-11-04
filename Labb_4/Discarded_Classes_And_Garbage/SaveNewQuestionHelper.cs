using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Labb_4 {
    public class SaveNewQuestionHelper : SaveNewQuizHelper {

        private string _statement = "";

        [XmlAttribute("Statement")]
        public string Statement {
            get { return _statement; }
            set { _statement = value; }
        }

        private string[] _answers;

        public string[] Answers {
            get { return _answers; }
            set { _answers = value; }
        }

        private string _correctAnswer;

        public string CorrectAnswer {
            get { return _correctAnswer; }
        }

        public SaveNewQuestionHelper() {
            
        }

        public SaveNewQuestionHelper(string statement, string stupidCorrectReadonlyQuestion, params string[] answers) {// string answerOne, string answerTwo, string answerThree

            _correctAnswer =  stupidCorrectReadonlyQuestion; // = int.Parse(stupidCorrectReadonlyQuestion);
            Statement = statement;
            Answers = answers; //= new string[] {answerOne, answerTwo, answerThree};

        }

        //public SaveNewQuestionHelper(string statement, int stupidCorrectReadonlyQuestion, params string[] answers) {

        //    _correctAnswer = stupidCorrectReadonlyQuestion;
        //    Statement = statement;
        //    Answers = answers;

        //}
    }
}