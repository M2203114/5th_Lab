﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _5th_Lab
{
    internal class Error
    {
        static string message = "Ooops...";
        public static void Kill()
        {
            Console.Error.WriteLine(message);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
