using Assignment_1_Course_2_Jobapplication_Tracker.Scripts.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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
        public void AddJobapplication()
        {
            //Creating a Job Application!
            Jobapplication JobApp = new Jobapplication();


            //Write AddApplication Menu!
            Console.WriteLine(Print.text["Title"]);
            Console.WriteLine($"         <:Add Application:>                    (You got {Applications.Count()} applications)");

            //Ask for Company Name!
            Console.Write("Company Name: ");
            User.ReadInput();
            JobApp.CompanyName = User.Input;//Add Company Name to Application!

            //Ask for Job Position!
            Console.Write("Job Position: ");
            User.ReadInput();
            JobApp.PositionTitle = User.Input;//Add Position Title to Application!

            //
            User.Int = 0;
            Console.Write("Salary Expection: ");
            User.ReadInt();

            //If User.Int <= 0, ask for a higher value!
            while (User.Int <= 0)
            {
                Console.WriteLine("Invalid input! Enter a positive number!");
                Console.Write("Salary Expection: ");
                User.ReadInt();
            }
            JobApp.SalaryExpectaion = User.Int;//Add Salary Expectation to Application!


            //
            Console.WriteLine("<=:Date when applied:=>");
            JobApp.ApplicationDate = new DateTime(0001, 01, 01);

            //
            User.Int = 0;
            Console.Write("Year: ");
            User.ReadInt();
            while (User.Int > DateTime.Now.Year || User.Int < 1900)
            {
                Console.WriteLine($"Invalied year! Type a year between 1900 and {DateTime.Now.Year}!");
                Console.Write("Year: ");
                User.ReadInt();
            }
            JobApp.ApplicationDate = JobApp.ApplicationDate.AddYears(User.Int - 1);

            //
            User.Int = 0;
            Console.Write("Month: ");
            User.ReadInt();
            while (User.Int > DateTime.Now.Month && JobApp.ApplicationDate.Year == DateTime.Now.Year || User.Int < 1 || User.Int > 12)
            {
                if (User.Int > DateTime.Now.Month && JobApp.ApplicationDate.Year == DateTime.Now.Year)
                {
                    Console.WriteLine($"Invalied month! Type a month between 1 and {DateTime.Now.Month}!");
                    Console.Write("Month: ");
                    User.ReadInt();
                }
                else
                {
                    Console.WriteLine($"Invalied month! Type a month between 1 and 12!");
                    Console.Write("Month: ");
                    User.ReadInt();
                }

            }
            JobApp.ApplicationDate = JobApp.ApplicationDate.AddMonths(User.Int - 1);

            //Check how many days there are in the month of a year that has been chosen by JobApp.Month!
            //Made it into a Variable because the line where so long and made the comming while check long and messy to read! 😓
            int MaxDayRange = DateTime.DaysInMonth(JobApp.ApplicationDate.Year, JobApp.ApplicationDate.Month);

            User.Int = 0;
            Console.Write("Day: ");
            User.ReadInt();
            //Check if the User have entered a value higher then 0 and that the number is not higher then MaxDayRange and that
            while (User.Int <= 0 || User.Int > MaxDayRange || User.Int > DateTime.Now.Day && JobApp.ApplicationDate.Year == DateTime.Now.Year && JobApp.ApplicationDate.Month == DateTime.Now.Month)
            {
                if (JobApp.ApplicationDate.Year == DateTime.Now.Year && JobApp.ApplicationDate.Month == DateTime.Now.Month && MaxDayRange > DateTime.Now.Day)
                {
                    Console.WriteLine($"Invalied day! Type a day between 1 and {DateTime.Now.Day}!");
                    Console.Write("Day: ");
                    User.ReadInt();
                }

                else
                {
                    Console.WriteLine($"Invalied day! Type a day between 1 and {MaxDayRange}!");
                    Console.Write("Day: ");
                    User.ReadInt();
                }

            }
            JobApp.ApplicationDate = JobApp.ApplicationDate.AddDays(User.Int - 1);

            //Set the JobApplication Status!
            Console.WriteLine("<=:Job Application Status:=>");
            Console.WriteLine("1.(Applied)   2.(Interviewed)\n3.(Offered)   4.(Rejected)");

            Console.Write("Input: ");
            User.ReadInput();

            switch (User.Input.ToLower())
            {

                case "1":
                case "applied":
                    JobApp.Status = Jobapplication.ApplicationStatus.Applied;
                    break;

                case "2":
                case "interview":
                    JobApp.Status = Jobapplication.ApplicationStatus.Interview;
                    break;

                case "3":
                case "offer":
                    JobApp.Status = Jobapplication.ApplicationStatus.Offer;
                    break;

                case "4":
                case "rejected":
                    JobApp.Status = Jobapplication.ApplicationStatus.Rejected;
                    break;

            }

            //If anything but Status == Applied, ask when they resived a response. If Applied, you have yeat resived a response!
            if (JobApp.Status != Jobapplication.ApplicationStatus.Applied)
            {
                Console.WriteLine("<=:When did you get a response?:=>");

                User.Int = 0;
                Console.Write("Year: ");
                User.ReadInt();


                //
                while (JobApp.ApplicationDate.Year > User.Int || DateTime.Now.Year < User.Int)
                {
                    Console.WriteLine($"Invalied year! Type a year between {JobApp.ApplicationDate.Year} or {DateTime.Now.Year}!");
                    Console.Write("Year: ");
                    User.ReadInt();
                }

                JobApp.ResponseDate = JobApp.ResponseDate.AddYears(User.Int - 1);


                //
                User.Int = 0;
                Console.Write("Month: ");
                User.ReadInt();

                while (User.Int < JobApp.ApplicationDate.Month && JobApp.ApplicationDate.Year == JobApp.ResponseDate.Year || User.Int > DateTime.Now.Month || User.Int > 12 || User.Int < 1)
                {
                    if (JobApp.ApplicationDate.Month > User.Int)
                    {
                        Console.WriteLine($"Invalied month! Type a month same as {DateTime.Now.Month} or higher!");
                        Console.Write("Month: ");
                        User.ReadInt();
                    }

                    else
                    {
                        Console.WriteLine($"Invalied month! Type a month that is past or the same as the application month!");
                        Console.Write("Month: ");
                        User.ReadInt();
                    }

                }

                JobApp.ResponseDate = JobApp.ResponseDate.AddMonths(User.Int - 1);


                //
                User.Int = 0;
                Console.Write("Day: ");
                User.ReadInt();

                while (User.Int < 1 || User.Int > MaxDayRange || User.Int > DateTime.Now.Day && JobApp.ApplicationDate.Year == DateTime.Now.Year && JobApp.ApplicationDate.Month == DateTime.Now.Month || JobApp.ApplicationDate.Day > User.Int)
                {
                    if (JobApp.ApplicationDate.Year == DateTime.Now.Year && JobApp.ApplicationDate.Month == DateTime.Now.Month && MaxDayRange > DateTime.Now.Day)
                    {
                        Console.WriteLine($"Invalied day! Type a day between 1 and {DateTime.Now.Day}!");
                        Console.Write("Day: ");
                        User.ReadInt();
                    }

                    else
                    {
                        Console.WriteLine($"Invalied day! Type a day between 1 and {MaxDayRange}!");
                        Console.Write("Day: ");
                        User.ReadInt();
                    }

                }
                JobApp.ResponseDate = JobApp.ResponseDate.AddDays(User.Int - 1);

            }

            //Add Application to Applications List!
            Applications.Add(JobApp);

            Console.WriteLine("Job Application has been added!");

            Console.ReadKey();


        }//Finish running task!


        //Show Applications!
        public void ShowApplications()
        {

            //Write ShowApplication Menu!
            Console.WriteLine(Print.text["Title"]);
            Console.WriteLine($"         <:Show Application:>                   (You got {Applications.Count()} applications)");

            Console.WriteLine($"(All)  (Esc)  ");
            User.Int = 0;
            foreach (var application in Applications)
            {
                Console.Write($"({application.CompanyName})  ");
                User.Int++;

                if (User.Int >= 4)
                {
                    Console.Write("\n");
                    User.Int = 0;
                }
            }
            User.Int = 0;

            //
            Console.Write("Input: ");
            User.ReadInput();

            //If User.Input == All, print all job applications!
            if (User.Input.ToLower() == "all" || User.Input.ToLower() == "esc")
            {

                switch (User.Input.ToLower())
                {

                    case "all":

                        Console.Clear();
                        Console.WriteLine(Print.text["Title"]);
                        Console.WriteLine($"         <:Show Application:>                   (You got {Applications.Count()} applications)");


                        foreach (var application in Applications)
                        {

                            application.GetSummary();

                        }

                        break;


                    case "esc":
                        Console.Clear();
                        return;


                }

            }

            //If User.Input == Existing Application, print that Job Application!
            else if (Applications.Exists(application => application.CompanyName.ToLower() == User.Input.ToLower()))
            {
                User.Int = Applications.FindIndex(application => application.CompanyName.ToLower() == User.Input.ToLower());

                Console.Clear();
                Console.WriteLine(Print.text["Title"]);
                Console.WriteLine($"         <:Show Application:>                   (You got {Applications.Count()} applications)");


                Applications[User.Int].GetSummary();
                Console.WriteLine("");

            }

            //If User.Input don't == anything, type that it's a Invalied Command!
            else
            {
                Console.WriteLine("Invalied Command!");
            }

            Console.ReadKey();


        }//Finish running task!




        //UpdateStatus of a Application!
        public void UpdateStatus()
        {
            //Write UpdateStatus Menu!
            Console.WriteLine(Print.text["Title"]);
            Console.WriteLine($"         <:Update Status:>                   (You got {Applications.Count()} applications)");
            Console.WriteLine("(Esc)");


            //If no application in Applications!
            if (Applications.Count < 1)
            {
                Console.WriteLine("You have no available Applications!");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            //If application/ applications exist in Applications!

            //Print the Job Applications name so the user can see them!
            User.Int = 0;
            foreach (var application in Applications)
            {
                Console.Write($"({application.CompanyName})   ");
                User.Int++;
                if (User.Int >= 4)
                {
                    Console.Write("\n");
                    User.Int = 0;
                }
            }
            Console.WriteLine("");
            User.Int = 0;

            //Ask User for input!
            Console.Write("Input: ");
            User.ReadInput();
            
            switch (User.Input.ToLower())
                {
                
                case "esc":
                    Console.Clear();
                    break;
                
                default:
                    
                    if (Applications.Exists(application => application.CompanyName.ToLower() == User.Input.ToLower()))
                    {
                        
                        var AppIndex = Applications.FindIndex(application => application.CompanyName.ToLower() == User.Input.ToLower());

                        Console.WriteLine("<=:What is the new status?:=>");
                        Console.WriteLine("1.(Applied)   2.(Interviewed)   3.(Offered)   4.(Rejected)   ");

                        Console.Write("Input");
                        User.ReadInput();
                        
                        switch (User.Input.ToLower())
                        {
                            
                            default:
                                Print.ErrorCode("Invalie Input!");
                                break;
                            
                            case "1":
                            case "applied":
                                Applications[AppIndex].Status = Jobapplication.ApplicationStatus.Applied;
                                break;

                            case "2":
                            case "interviewed":
                            case "interview":
                                Applications[AppIndex].Status = Jobapplication.ApplicationStatus.Interview;
                                break;
                            
                            case "3":
                            case "offered":
                            case "offer":
                                Applications[AppIndex].Status = Jobapplication.ApplicationStatus.Offer;
                                break;
                            
                            case "4":
                            case "rejected":
                            case "reject":
                                Applications[AppIndex].Status = Jobapplication.ApplicationStatus.Rejected;
                                break;

                            }

                            Console.WriteLine("Status has been updated!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Name NOT found!");
                        }

                        break;

            }

        }//Finish running task!



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
