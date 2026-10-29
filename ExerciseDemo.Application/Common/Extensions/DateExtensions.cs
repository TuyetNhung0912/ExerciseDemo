using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDemo.Application.Common.Extensions
{
    public static class DateExtensions
    {
        public static DateTime StartOfDay(this DateTime date)
        {
            return date.Date;
        }

        public static DateTime EndOfDay(this DateTime date) 
        {
            return date.Date.AddDays(1).AddTicks(-1); 
        }

        public static bool IsBetween(this DateTime date, DateTime startDate, DateTime endDate)
        {
            return date >= startDate && date <= endDate;
        }
    }
}
