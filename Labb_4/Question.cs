﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Labb_4 {
    public class Question : Quiz {

        private string _statement = "";

        //[XmlAttribute("Statement")]
        public string Statement
        {
            get { return _statement; }
            set { _statement = value; }
        }
        
        private string[] _answers = new string[3];

        public string[] Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }
        
        private readonly int _correctAnswer;//Sätta till ett värde och sedan ändra så att rätt svar måste ha just den variabeln? -.-

        public int CorrectAnswer
        {
            get { return _correctAnswer; }
        }

        //public Question() {
            
        //    //FÖr att instansieras på första sidan i foreach loop för att fylla frågan, kanske ta bort om ändrar saker där..

        //}

        public Question(string statement, int correctQuestion, params string[] answers) : base(String.Empty, 0, new string[]{}) {

            Statement = statement;
            _correctAnswer = correctQuestion;
            Answers = answers;
            
        }

    }
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