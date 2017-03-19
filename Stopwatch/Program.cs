using System;

namespace Stopwatch
{



    class Program
    {
        private static void menuSwitch(int input, Stopwatch stopwatch, string error)
        {

            switch (input)
            {
                case 1:
                    stopwatch.Start();
                    break;
                case 2:
                    stopwatch.Stop();
                    break;
                case 3:
                    stopwatch.TimeCheck();
                    break;
                case 4:
                    stopwatch.ResetStopwatch();
                    break;
                default:
                    Console.WriteLine(error);
                    break;
            }
        }

        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            string menu = "To Start Stopwatch, Press: 1\nTo Stop  Stopwatch, Press: 2\nFor Current Stopwatch Time, Press: 3\nTo Reset Stopwatch, Press: 4\nTo Exit  Stopwatch, Press: 5";
            string inputError = "Invalid input! Please input valid number.";
            int response = 0;


            Console.WriteLine("Stopwatch State is: {0}, Stopwatch time is: {1}\n"+menu,stopwatch.State, stopwatch.Duration);
            if (int.TryParse(Console.ReadLine(), out response)) { }
            
            while (response != 5)
            {
                menuSwitch(response, stopwatch, inputError);
                /*if (response == 1)
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
                }*/

                if (response == 5)
                {
                    Environment.Exit(0);
                }
                /*else
                {
                    Console.WriteLine(inputError);
                }*/
                if (response != 0)
                {
                    Console.WriteLine("Stopwatch State is: {0}, Stopwatch time is: {1}\n" + menu, stopwatch.State, stopwatch.Duration);
                    if (int.TryParse(Console.ReadLine(), out response)) { }
                }
            }
        }

    }
}
