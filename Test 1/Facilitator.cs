using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    public class Facilitator : Human
    {
        public override void AnswerQuestions()
        {
            base.AnswerQuestions();
            Console.WriteLine("Gives additonal resources after explanation");
        }

        public override void AskQuestions()
        {
            Console.WriteLine("Ask questions to Students only");
        }
    }
}
