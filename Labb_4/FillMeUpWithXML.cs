﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Labb_4 {
    public class FillMeUpWithXML : IEnumerable {

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

        public IEnumerator GetEnumerator() {
            throw new NotImplementedException();
        }

        //public void Add<T>(T value) {
        //    throw new NotSupportedException("Please remove error?");
        //}

    }
}
