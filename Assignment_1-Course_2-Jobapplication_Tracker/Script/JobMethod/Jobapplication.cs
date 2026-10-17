using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Assignment_1_Course_2_Jobapplication_Tracker.Scripts.Job_Metohds
{
    public class Jobapplication
    {

        public class Application
        {
            //Class Variables
            public string? CompanyName;
            public string? PositionTitle;
            public enum ApplicationStatus
            {
                Applied,
                Interview,
                Offer,
                Rejected,
                Unknown
            }
            public ApplicationStatus Status = ApplicationStatus.Unknown;
            public DateTime ApplicationDate;
            public DateTime ResponseDate;
            public int ResponseTimeDays = -1;
            public int SalaryExpectaion = -1;



            //Get Days Since Applied and Recived a Response!
            public void DaysSinceApplied()
            {

                TimeSpan DaySpan = ResponseDate - ApplicationDate;
                ResponseTimeDays = DaySpan.Days;

            }


            //Get Application Summary!
            public void GetSummary()
            {
                //Run DaysSinceApplied(); method!
                DaysSinceApplied();


            }

        }
    }
}
