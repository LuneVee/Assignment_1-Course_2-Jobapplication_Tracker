using Assignment_1_Course_2_Jobapplication_Tracker.Scripts.Job_Metohds;

namespace Assignment_1_Course_2_Jobapplication_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Progam Variables!\\
            bool RunProgram = true;

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



            }

        }
    }
}
