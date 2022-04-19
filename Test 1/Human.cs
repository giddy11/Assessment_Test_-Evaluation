using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    public abstract class Human
    {


        public void AttendClasses()
        {
            Console.WriteLine("Attend Classes");
        }

        public abstract void AskQuestions();


        public virtual void AnswerQuestions()
        {
            Console.WriteLine("Answer questions and give explanation");
        }
        


        public string Name { get; set; }
    }
}
