using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01378530_BonusAssignment_Timothy
{
    public partial class Bonus2WeeklyCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // == variables ==
            // days of week list
            List<string> DaysOfWeek = new List<string>
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            /* client work days of a week
             * if work, true. 
             * the list would be like 
             * [false, true, true, false, true, true, true]
             * means not working on Monday or Thursday
             */
            List<bool> WorkDaysOfWeek = new List<bool>();

            // if post back
            if (IsPostBack)
            {
                // clean the html
                client_calendar.InnerHtml = "";

                // add the selected work days to list
                foreach (ListItem item in client_weekly_schedule.Items)
                {
                    if (item.Selected)
                    {
                        // working this day
                        WorkDaysOfWeek.Add(true);
                    }
                    else
                    {
                        // not working this day
                        WorkDaysOfWeek.Add(false);
                    }
                }

                // index of day of week
                int DayOfWeek;

                /* correction of the first day of a month
                 * if the first day of a month is Monday, correction should be 0
                 * if the first day of a month is Tuesday, correction should be 1
                 * if the first day of a month is Wednesday, correction should be 2
                 * ...
                 * if the first day of a month is Sunday, correction should be 6
                 */
                int FirstDayOfMonthCorrection;
                // Oct.1 is Tuesday, so Correction = 1
                FirstDayOfMonthCorrection = 1;

                // what to do that day ( have fun or work )
                string WhatToDo;

                for (int i = 1; i <= 31; i++)
                {
                    // minus one for index of day ( index starts at 0 )
                    DayOfWeek = (i - 1 + FirstDayOfMonthCorrection) % 7;

                    // if it's work day
                    if (WorkDaysOfWeek[DayOfWeek])
                    {
                        WhatToDo = "work...";
                    }
                    else
                    {
                        WhatToDo = "have fun!";
                    }

                    // Day plus one for Oct 1st is Tuesday ( one day after the first day of week )
                    client_calendar.InnerHtml += "Oct " + i + " is a " + DaysOfWeek[DayOfWeek]
                        + "! Time to " + WhatToDo + "<br>";
                }
            }

        }
    }
}