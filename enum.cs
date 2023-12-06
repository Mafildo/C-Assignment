using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    public class Calendar
    {

        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        // Method to print weekdays from the DaysOfWeek enum
        public void PrintWeekdays()
        {
            Console.WriteLine("Weekdays:");


            foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
            {
                if (day >= DaysOfWeek.Monday && day <= DaysOfWeek.Friday)
                {
                    Console.WriteLine(day);
                }
            }
        }
    }
}
