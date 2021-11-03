using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Labb_4 {
    public class Question : Quiz {

        private string _statement;

        //[XmlAttribute("Statement")]
        public string Statement
        {
            get { return _statement; }
            set { _statement = value; }
        }

        private string[] _answers;

        public string[] Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }

        //private string[] _answerOne;

        //public string[] AnswerOne {
        //    get { return _answerOne; }
        //    set { _answerOne = value; }
        //}

        //private string[] _answerTwo;

        //public string[] AnswerTwo {
        //    get { return _answerTwo; }
        //    set { _answerTwo = value; }
        //}

        //private string[] _answerThree;

        //public string[] AnswerThree {
        //    get { return _answerThree; }
        //    set { _answerThree = value; }
        //}

        private readonly int _correctAnswer;

        public int CorrectAnswer
        {
            get { return _correctAnswer; }
        }

        public Question(string statement, int stupidCorrectReadonlyQuestion, params string[] answers) {

            _correctAnswer = stupidCorrectReadonlyQuestion;
            Statement = statement;
            Answers = answers;

        }

    }
}
