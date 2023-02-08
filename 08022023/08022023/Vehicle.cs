using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace _08022023
{
    internal class Vehicle
    {

        public string brand;
        public string model;
        public double millage;
        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {brand} - Model: {model} - Millage: {millage}");
        }


    }
}
