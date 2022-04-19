using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    public abstract class Human 
    {
        

        public void AttendClasses(DaysOfWeek daysOfWeek)
        {
            if(Programme == Programme.Backend && (daysOfWeek == DaysOfWeek.Monday || daysOfWeek == DaysOfWeek.Tuesday || daysOfWeek == DaysOfWeek.Thursday))
            {
                Console.WriteLine(Name);
                Console.WriteLine($"The Host will let you in shortly because today is {daysOfWeek}");
                Thread.Sleep(5000);
                Console.WriteLine("you're in!\n\n");
            }
            else if(Programme == Programme.Frontend && (daysOfWeek == DaysOfWeek.Tuesday || daysOfWeek == DaysOfWeek.Wednesday || daysOfWeek == DaysOfWeek.Thursday))
            {
                Console.WriteLine(Name);
                Console.WriteLine($"The Host will let you in shortly because today is {daysOfWeek}");
                Thread.Sleep(5000);
                Console.WriteLine("you're in!\n\n");
            }
            else Console.WriteLine($"{Name} No class today because today is {daysOfWeek}\n\n");
        }

        public abstract void AskQuestions();


        public virtual void AnswerQuestions()
        {
            Console.WriteLine("Answer questions and give explanation");
        }
       
        public string Name { get; set; }
        public Programme Programme { get; set; }
    }
}
