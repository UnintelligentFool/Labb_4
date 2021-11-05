using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb_4 {
    class editAs_XML_Blueprint {

        private string _statement;

        public string Statement {
            get { return _statement; }
            set { _statement = value; }
        }

        private string _answerOne;

        public string AnswerOne {
            get { return _answerOne; }
            set { _answerOne = value; }
        }

        private string _answerTwo;

        public string AnswerTwo {
            get { return _answerTwo; }
            set { _answerTwo = value; }
        }

        private string _answerThree;

        public string AnswerThree {
            get { return _answerThree; }
            set { _answerThree = value; }
        }

        private int _correctAnswer;

        public int CorrectAnswer {
            get { return _correctAnswer; }
            set { _correctAnswer = value; }
        }

        public editAs_XML_Blueprint() {

            XElement Questions =
                new XElement("Question",
                    new XElement("The_Statement",
                        new XElement("Statement", Statement)
                    ),
                    new XElement("The_Answers",
                        new XElement("Answer_One", AnswerOne),
                        new XElement("Answer_Two", AnswerTwo),
                        new XElement("Answer_Three", AnswerThree)
                    ),
                    new XElement("The_Correct_Answer",
                        new XElement("Correct_Answer", CorrectAnswer)
                    )
                );


        }

    }
}