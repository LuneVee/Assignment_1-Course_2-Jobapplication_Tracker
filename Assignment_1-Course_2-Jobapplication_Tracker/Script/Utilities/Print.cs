using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_Course_2_Jobapplication_Tracker.Scripts.Utilities
{
    static class Print //This Class is used to keep the main codes more clean and to make it easier to create Console Visuals!
    {

        //text Dictionary. Can be used to add custom text and then access easely it from any Class!
        public static Dictionary<string, string> text = new Dictionary<string, string>
        {
            //Example text:
            ["Hello"] = $"Hello World!",
            ["Yes"] = $"I agree!",
            ["No"] = $"I don't agree!",

        };




        //ERROR CODE!
        public static void ErrorCode(string ErrorMessage)//Write a RED Error code with a Error Message!
        {

            Console.BackgroundColor = ConsoleColor.Red;                         //Turn character background RED!
            Console.ForegroundColor = ConsoleColor.White;                       //Turn characters WHITE!
            Console.Write($"ERROR! {ErrorMessage}");                            //Write Message to Console Application!
            Console.ResetColor();                                               //Reset character colors!

        }



        //


    }
}
