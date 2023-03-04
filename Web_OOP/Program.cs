using System;

namespace Web_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please type year:");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Please type month:");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("Please type day");
                int day = int.Parse(Console.ReadLine());


                var dataObject = new Date(day, month, year);
                Console.WriteLine(dataObject.ToString());
            }
            catch (Exception message)
            {
               Console.WriteLine(message.ToString());
            }
          
        }
    }
}
