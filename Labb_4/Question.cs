using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4 {
    class Question : Quiz {

        private string _statement;

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

        private readonly int _correctAnswer;

        public int CorrectAnswer
        {
            get { return _correctAnswer; }
        }

    }
}
