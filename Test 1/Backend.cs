using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    public class Backend : CCSA, IMondayClass
    {
        public void AttendMondayClass(DaysOfWeek daysOfWeek)
        {
            if (daysOfWeek == DaysOfWeek.Monday)
            {
                
                Console.WriteLine($"The Host will let you in shortly because today is {daysOfWeek}");
                Thread.Sleep(5000);
                Console.WriteLine("you're in!\n\n");
            }
            else Console.WriteLine($"No class today because today is {daysOfWeek}\n\n");
        }





    }
}
