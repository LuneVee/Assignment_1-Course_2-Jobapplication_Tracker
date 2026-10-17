using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_Course_2_Jobapplication_Tracker.Scripts.Job_Metohds
{
    public class JobManager
    {

        public List<Jobapplication> Applications = new List<Jobapplication>()
        {

            //Already added Job Applications inside of Applications!
            new Jobapplication ()
            {
                CompanyName = "Microsoft",
                PositionTitle = "Software Enginer",
                Status = Jobapplication.ApplicationStatus.Applied,
                ApplicationDate = new DateTime(2026,09,20),
                ResponseDate = new DateTime(0001,01,01),
                SalaryExpectaion = 35000
            },

            new Jobapplication ()
            {

                CompanyName = "Google",
                PositionTitle = "Housekeeper",
                Status = Jobapplication.ApplicationStatus.Applied,
                ApplicationDate = new DateTime(2026,10,5),
                ResponseDate = new DateTime(0001,01,01),
                SalaryExpectaion = 25500

            },

            new Jobapplication ()
            {

                CompanyName = "Sony",
                PositionTitle = "Office Worker",
                Status = Jobapplication.ApplicationStatus.Rejected,
                ApplicationDate = new DateTime(2026,10,05),
                ResponseDate = new DateTime(2026,10,10),
                SalaryExpectaion = 31500

            },

            new Jobapplication ()
            {

                CompanyName = "Apple",
                PositionTitle = "Office Worker",
                Status = Jobapplication.ApplicationStatus.Interview,
                ApplicationDate = new DateTime(2026,10,05),
                ResponseDate = new DateTime(2026,10,09),
                SalaryExpectaion = 32500

            },

            new Jobapplication ()
            {

                CompanyName = "Max",
                PositionTitle = "Chef",
                Status = Jobapplication.ApplicationStatus.Rejected,
                ApplicationDate = new DateTime(2026,09,27),
                ResponseDate = new DateTime(2026,10,05),
                SalaryExpectaion = 29000

            },

        };



        //Create and add a Application to Applications list!
        public void AddJobApplication()
        {

        }



        //UpdateStatus of a Application!
        public void UpdateStatus()
        {

        }



        //Show Applications!
        public void ShowApplications()
        {

        }



        //Show Applications By Status!
        public void ShowApplicationsByStatus()
        {

        }



        //Show Applications By Date!
        public void ShowApplicationsByDate()
        {

        }



        //Remove Application!
        public void RemoveApplication()
        {

        }



        //Show Statistics
        public void ShowStatistics()
        {

        }



    }
}
