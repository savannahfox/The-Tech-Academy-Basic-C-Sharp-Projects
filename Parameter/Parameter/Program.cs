﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What number would you like to work with today?");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            Number number = new Number();
            number.Value = enteredNumber;
            int timesMultiplied = 0;
            number.MultiplicationLoop(number, out timesMultiplied, 4);

            Console.ReadLine();
        }
    }
}
