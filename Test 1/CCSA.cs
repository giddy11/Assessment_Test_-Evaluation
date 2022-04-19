using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    public class CCSA : ITuesdayClass, IThursdayClass
    {
        public void AttendThursdayClass(DaysOfWeek daysOfWeek)
        {
            if (daysOfWeek == DaysOfWeek.Thursday)
            {
                Console.WriteLine($"The Host will let you in shortly because today is {daysOfWeek}");
                Thread.Sleep(5000);
                Console.WriteLine("you're in!\n\n");
            }
            else Console.WriteLine($"No class today because today is {daysOfWeek}\n\n");
        }

        public void AttendTuesdayClass(DaysOfWeek daysOfWeek)
        {
            if (daysOfWeek == DaysOfWeek.Tuesday)
            {
                Console.WriteLine($"The Host will let you in shortly because today is {daysOfWeek}");
                Thread.Sleep(5000);
                Console.WriteLine("you're in!\n\n");
            }
            else Console.WriteLine($"No class today because today is {daysOfWeek}\n\n");
        }

        public List<Student> Students { get; set; }
        public List<Facilitator> Facilitators { get; set; }
    }
}
