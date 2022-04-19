using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    public class Student : Human
    {
        public override void AskQuestions()
        {
            Console.WriteLine("Ask question to Facilitators and fellow students");
        }
    }
}
