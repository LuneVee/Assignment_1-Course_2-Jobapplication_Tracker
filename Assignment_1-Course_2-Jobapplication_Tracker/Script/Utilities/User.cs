using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_Course_2_Jobapplication_Tracker.Scripts.Utilities
{
    static class User
    {

        //User Values!
        public static string? Input;        //string value. Type User.Input to access it!
        public static int Int = 0;          //int value. Type User.int_Input to access it!
        public static bool ValiedInput = false;




        //Read ``string´´ Input!
        public static void ReadInput()//Read whatever the Input is. Made this because I don't want to type ``User.Input = Console.ReadLine()´´ all the time!
        {

            Input = Console.ReadLine();                                             //Read what User entered and set it as User Input!
            if (Input.IsWhiteSpace())                                            //While User Input is empty or only space!
            {
                Print.ErrorCode("EMPTY INPUT! You need to type something!");        //Tell that the User has entered a empty Input and that they need to try again!
                ValiedInput = false;
                return;
                
            }
            else
            {
                ValiedInput = true;
            }

        }



        //Read ``int´´ Input!
        public static void ReadInt()//Read User Input and check if it can be used as an int variable!
        {

            //Check if the user has entered a whole number!
            string Num = Console.ReadLine();                                        //Read what User entered and set it as Num!
            while (!int.TryParse(Num, out Int))                                     //While loop if the Input is not able to convert into a number!
            {
                Console.WriteLine("Invalied Input. Need to be a whole number!");    //If Num is not a whole number or have entered other then number characters, print this text!
                Num = Console.ReadLine();                                           //Ask the User to enter a new Input!
            }

            Int = int.Parse(Num);                                                   //Input is able to become a int variable. Set Num as int_Input!

        }










    }
}
