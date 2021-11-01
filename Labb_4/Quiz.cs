using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4 {
    class Quiz : TheQuizMasterClass {

        private ICollection<Question> _questions;

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

        public Quiz()
        {
            
            

        }

 //       public Question GetRandomQuestion() {

  //          return(string);

//        }

        public void AddQuestion(string statement, int correctAnswer, params string[] answers) {

            //Questions<Question>.Add(<Question>(statement, correctAnswer, answers));

            Question questionToBeAdded = new Question(statement, correctAnswer, answers);
            
            Questions.Add(questionToBeAdded);
            
        }

        public void RemoveQuestion(int index) {



        }

}
}
