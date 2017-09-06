using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VermaNet.Common
{
    public class DateHelper
    {

        public static int GetWorkDaysInMonth(int month, int year)
        {
            // default to 5/7 of the month arbitrarily...
            var startDate = new DateTime(year, month, 1);
            var daysInMonth = DateTime.DaysInMonth(year, month);
            int result = 0;
            for(int dayNumber = 1; dayNumber <= daysInMonth; dayNumber++)
            {
                var currentDay = new DateTime(year, month, dayNumber);
                if(new[] { DayOfWeek.Saturday, DayOfWeek.Sunday}.Contains(currentDay.DayOfWeek))
                {
                    // Skip weekends
                    continue;
                }
                else
                {
                    result++;
                }
            }

            return result;
        }


        public static int GetWorkDaysInQuarter(int quarter, int year)
        {
            var relevantMonths = new List<int>();
            switch(quarter)
            {
                case 1:
                    relevantMonths.AddRange(new []{ 1, 2, 3});
                    break;

                case 2:
                    relevantMonths.AddRange(new[] { 4, 5, 6 });
                    break;

                case 3:
                    relevantMonths.AddRange(new[] { 7, 8, 9 });
                    break;

                case 4:
                    relevantMonths.AddRange(new[] { 10, 11, 12 });
                    break;

                default:
                    throw new ArgumentOutOfRangeException("quarter", "Invalid quarter was specified.  Valid values are 1, 2, 3, and 4.");

            }

            int result = 0;
            foreach(int month in relevantMonths.OrderBy(x=> x))
            {
                result += GetWorkDaysInMonth(month, year);
            }

            return result;
        }


    }
}
