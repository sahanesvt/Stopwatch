using System;

namespace Stopwatch
{



    class Program
    {
        private static void menuSwitch(int input, Stopwatch stopwatch, string error)
        {
            //if (input.Equals(typeof(int)))
            //{
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
                
            //}
        }

        private static void recursive(Stopwatch stopwatch, string menu, string display, string inputError, int response)
        {
            Console.WriteLine(display + menu, stopwatch.State, stopwatch.Duration);
            string selection = Console.ReadLine();

            if (int.TryParse(selection, out response))
            {
                while (response != 0)
                {
                    menuSwitch(response, stopwatch, inputError);
                    if (response == 5)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine(display + menu, stopwatch.State, stopwatch.Duration);
                        selection = Console.ReadLine();
                        if (int.TryParse(selection, out response)) { }
                    }
                }
            }
            else
            {
                Console.WriteLine(inputError);
                response = 0;
                recursive(stopwatch, menu, display, inputError, response);
            }
        }

        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            string menu = "To Start Stopwatch, Press: 1\nTo Stop  Stopwatch, Press: 2\nTo Check Stopwatch, Press: 3\nTo Reset Stopwatch, Press: 4\nTo Exit  Stopwatch, Press: 5";
            string display = "Stopwatch State is: {0}, Stopwatch time is: {1}\n";
            string inputError = "Invalid input! Please input valid number.";
            int response = 0;

            recursive(stopwatch, menu, display, inputError, response);
        }

    }
}
