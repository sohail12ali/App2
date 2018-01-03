using System;
using System.Collections.Generic;
using System.Text;


namespace App2.Helpers
{
    class GlobalData
    {
        private static string MyUsername { get; set; } = "sohail";
        private static string MyPassword { get; set; } = "1234";
 


        public static bool VerifyData(string username, string password)
        {
            return ((username == MyUsername) && (password == MyPassword)) ? true : false;
        }



    }

       
}
