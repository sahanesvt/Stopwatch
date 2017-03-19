using System;

namespace Stopwatch
{



    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            string menu = "To Start Stopwatch, Press: 1\nTo Stop  Stopwatch, Press: 2\nFor Current Stopwatch Time, Press: 3\nTo Reset Stopwatch, Press: 4\nTo Exit  Stopwatch, Press: 5";
            string inputError = "Invalid input! Please input valid number.";
            int response = 0;


            Console.WriteLine("Stopwatch State is: {0}, Stopwatch time is: {1}\n"+menu,stopwatch.State, stopwatch.Duration);
            if (Int32.TryParse(Console.ReadLine(), out response))
            {
                Convert.ToInt32(Console.ReadLine());
            }

            while (response != 5)
            {

                if (response == 1)
                {
                    stopwatch.Start();
                }
                else if (response == 2)
                {
                    stopwatch.Stop();
                }

                else if (response == 3)
                {
                    stopwatch.TimeCheck();
                }

                else if (response == 4)
                {
                    stopwatch.ResetStopwatch();
                }

                else if (response == 5)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine(inputError);
                }
                if (response != 0)
                {
                    Console.WriteLine("Stopwatch State is: {0}, Stopwatch time is: {1}\n" + menu, stopwatch.State, stopwatch.Duration);
                    response = Convert.ToInt16(Console.ReadLine());
                }
            }
        }

    }
}
