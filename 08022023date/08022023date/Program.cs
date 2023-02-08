using System;

namespace _08022023date
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Add date:");
            var date=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Add year:");
            int year=Convert.ToInt32(Console.ReadLine());

            date=date.AddYears(year);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }

      
        

    }
    
}
