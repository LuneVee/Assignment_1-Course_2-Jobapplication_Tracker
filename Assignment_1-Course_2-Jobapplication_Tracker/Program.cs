using Assignment_1_Course_2_Jobapplication_Tracker.Scripts.Job_Metohds;
using Assignment_1_Course_2_Jobapplication_Tracker.Scripts.Utilities;

namespace Assignment_1_Course_2_Jobapplication_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Progam Variables!\\
            bool RunProgram = true;
            string Title = "==============================:Assignment:==============================";
            Print.text["Title"] = $"{Title}";


            //Objects!
            JobManager JobManager = new JobManager();
            Jobapplication Application = new Jobapplication();


            //Program Commands List!
            List<string> Commands = new List<string>
            {
                "(Add Application)",
                "(Show Applications)",
                "(Sort by Status)",
                "(Sort by Date)",
                "(Show Statistics)",
                "(Update Application Status)",
                "(Remove Application)",
                "(Exit Program)"

            };



            //
            while (RunProgram == true)
            {
                //Create Menu!
                Console.WriteLine($"{Title}");
                Console.WriteLine($"         <:Commands:>                           (You got {JobManager.Applications.Count()} applications)");

                User.Int = 0;
                int CommandNum = 0;
                foreach (string command in Commands)
                {

                    if (User.Int >= 2)
                    {

                        User.Int = 0;
                        Console.Write("\n");

                    }

                    CommandNum++;
                    User.Int++;
                    Console.Write($"{CommandNum}.{command}   ");

                }


                Console.Write("\n\nInput: ");
                User.ReadInput();



                //Respond based on User Input!
                switch (User.Input)
                {
                    //If User Input == ``no case found´´ tell the user that is a Invalid Command and go back to start in while!
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalied Command!");
                        Console.Clear();
                        break;


                    //Add Job Application to Applications list!
                    case "1":
                        Console.Clear();
                        JobManager.AddJobapplication();
                        Console.Clear();
                        break;


                    //Show All Job Applications!
                    case "2":
                        Console.Clear();
                        JobManager.ShowApplications();
                        Console.Clear();
                        break;


                    //Show All Job Applications By Status!
                    case "3":
                        Console.Clear();
                        JobManager.ShowApplicationsByStatus();
                        Console.Clear();

                        break;


                    //
                    case "4":
                        Console.Clear();
                        JobManager.ShowApplicationsByDate();
                        Console.Clear();
                        break;


                    //
                    case "5":
                        Console.Clear();
                        JobManager.ShowStatistics();
                        Console.Clear();
                        break;


                    //Update Status of a Job Application!
                    case "6":
                        Console.Clear();
                        JobManager.UpdateStatus();
                        Console.Clear();
                        break;


                    //
                    case "7":
                        Console.Clear();
                        JobManager.RemoveApplication();
                        Console.Clear();
                        break;


                    //End Program!
                    case "8":
                        RunProgram = false;
                        break;




                }
            }

        }
    }
}
