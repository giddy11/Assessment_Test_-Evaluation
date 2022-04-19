using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    public class Frontend : CCSA, IWednesdayClass
    {

        public void AttendWednesdayClass(DaysOfWeek daysOfWeek)
        {
            if(daysOfWeek == DaysOfWeek.Wednesday)
            {
                Console.WriteLine("The Host will let you in shortly");
                Thread.Sleep(5000);
                Console.WriteLine("you're in!\n\n");

            }
            else Console.WriteLine($"No class today because today is {daysOfWeek}\n\n");
        }
    }
}
