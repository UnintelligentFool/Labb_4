using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml.Serialization;

namespace Labb_4 {

    public class Quiz : TheQuizMasterClass {

        private ICollection<Question> _questions = new List<Question>();

        public ICollection<Question> Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        
        public Quiz(string statement, int correctAnswer, params string[] answers) {

        }

        public void AddQuestion(string statement, int correctAnswer, params string[] answers) {

            Question questionToBeAdded = new Question(statement, correctAnswer, answers);

            Questions.Add(questionToBeAdded);
            
        }

        public void RemoveQuestion(int index) {



        }

}
}