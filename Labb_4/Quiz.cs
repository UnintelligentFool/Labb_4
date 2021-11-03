using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4 {
    public class Quiz : TheQuizMasterClass {

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

            //Är det fortfarande en ICollection och inte en list? Här ser det ut som om jag måste göra så här för att undkomma error:
            //https://stackoverflow.com/questions/42409426/icollection-in-viewmodel-causing-a-null-reference-exception/42409530
            Questions = new List<Question>();

            Questions.Add(questionToBeAdded);
            
        }

        //public void RevealThoughself() {

        //    foreach (var question in Questions) {

        //        question.ToString();

        //    }

        //}

        public void RemoveQuestion(int index) {



        }

}
}
