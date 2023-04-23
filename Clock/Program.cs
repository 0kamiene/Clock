using System;
using System.Runtime.CompilerServices;

namespace Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char app = 'y';
            do
            {
                Console.WriteLine("- Clock Angle Calculator -");
                int hours;
                int minutes;
                //hours
                do{
                    Console.WriteLine("Input hours (0-12):");
                    hours = int.Parse(Console.ReadLine());
                } while (hours < 0 || hours > 12);
                //minutes
                do{
                    Console.WriteLine("Input minutes (0-59):");
                    minutes = int.Parse(Console.ReadLine());
                } while (minutes < 0 || minutes > 59);
                //angle computation
                float hoursA = (hours % 12 + (float)minutes / 60) * 30;
                float minutesA = minutes * 6;
                float angle = (hoursA - minutesA);
                if (angle > 180){
                    angle = 360 - angle;
                }

                Console.WriteLine("The angle between the hour arrow and minute arrow is " + Math.Abs(angle) + " degrees.");
                
                //restart app
                do{
                   Console.WriteLine("Do you want to do it again? (y or n)");
                   app = (Console.ReadLine().ToLower()[0]);
                }while(app != 'y' && app != 'n');

                //clear screen
                Console.Clear();

            } while (app == 'y');
        }
    }
}