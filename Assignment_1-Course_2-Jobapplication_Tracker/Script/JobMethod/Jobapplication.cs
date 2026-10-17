using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Assignment_1_Course_2_Jobapplication_Tracker.Scripts.Job_Metohds
{
    public class Jobapplication
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
            
            //Write
            Console.WriteLine($"Company Name        :({CompanyName})");
            Console.WriteLine($"Job Position        :({PositionTitle})");
            Console.WriteLine($"Current Status      :({Status})");
            Console.WriteLine($"Application Date    :({ApplicationDate.Year}/{ApplicationDate.Month}/{ApplicationDate.Day})");
            
            //Write Response Date if >= 0!
            if (ResponseTimeDays >= 0)
            {

                Console.WriteLine($"Response time       :({ResponseTimeDays} days)");
            
            }
            
            else
            {
                
                Console.WriteLine($"Response time       :(Response NOT received)");
            
            }//
             
            Console.WriteLine($"Salary Expectation  :({SalaryExpectaion})");

            

        }//
    }
}
