using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_II
{
    public class Person
    {
        private string name;
        private string country;
        private string dob;

        public Person(string name, string country, string dob)
        {
            this.name = name;
            this.country = country;
            this.dob = dob;
        }

        public int CalculateAge()
        {
            bool validDate = DateTime.TryParseExact(this.dob, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate);
            DateTime dateTime = DateTime.Now;
            int currentYear = dateTime.Year;
            int currentMonth = dateTime.Month;
            int currentDay = dateTime.Day;

            string[] date = this.dob.Split("-");
            int year = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int day = int.Parse(date[2]);


            if (validDate && ((year > 0 && year <= currentYear) && (month <= 12 && month >= 1) && (day <= 31 && day >= 1)))
            {
                if (month == 2 && day > 29)
                {
                    throw new FormatException();
                }
                else
                {
                    if (month > currentMonth)
                    {
                        return currentYear - year - 1;
                    }
                    else if (month < currentMonth)
                    {
                        return currentYear - year;
                    }
                    else
                    {
                        if (currentDay < day)
                        {
                            return currentYear - year - 1;
                        }
                        else
                            return currentYear - year;
                    }
                }


            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
