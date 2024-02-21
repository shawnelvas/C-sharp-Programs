using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Easy.Set_I
{
  
    public class Task7
    {
        public string FormatDate(string inputDate)
        {
            bool validDate = DateTime.TryParseExact(inputDate, "dd-mm-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate);

            if (!validDate)
            {
                throw new FormatException();
            }
            else
            {
                string[] strDate = inputDate.Split("-");

                string day = strDate[0];
                string month = strDate[1];
                string year = strDate[2];

                int date = Int32.Parse(strDate[0]);
                string suffix = String.Empty;

                if (date > 0 && date <= 31)
                {
                    switch (date)
                    {
                        case 1:
                        case 21:
                        case 31:
                            suffix = "st";
                            break;

                        case 2:
                        case 22:
                            suffix = "nd";
                            break;

                        case 3:
                        case 23:
                            suffix = "rd";
                            break;

                        default:
                            suffix = "th";
                            break;
                    }
                }
                string[] mon = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
                int m = int.Parse(month);

                string monthAbbreviation = mon[m - 1];

                string finalDateFormat = $"{date}{suffix} {monthAbbreviation} {year}";
                return finalDateFormat;
            }



        }

    }
}

  
 
 
 