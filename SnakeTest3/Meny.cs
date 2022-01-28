using static SnakeTest3.Snake;

namespace SnakeTest3
{
    internal class Meny
    {
        public void Dameny() {

            string[] snakeBaner = new[]
            {
                @"  _________              .__         ",
                @" /   _____/ ____   _____ |  | _____   ",
                @" \_____  \_/ __ \ /     \|  | \__  \  ",
                @" /        \  ___/|  Y Y  \  |__/ __ \_",
                @"/_______  /\___  >__|_|  /____(____  /",
                @"        \/     \/      \/          \/ ",
                @"  _________              __           ",
                @" /   _____/ ____ _____  |  | __ ____  ",
                @" \_____  \ /    \\__  \ |  |/ // __ \ ",
                @" /        \   |  \/ __ \|    <\  ___/ ",
                @"/_______  /___|  (____  /__|_ \\___  >",
                @"        \/     \/     \/     \/    \/ ",
            };

            static void ShowBaner(string[] baner, int Y)
            {
                foreach (string line in baner)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition((Console.WindowWidth / 2) - (line.Length / 2), Y);
                    Console.WriteLine(line);
                    Y++;
                }
            }


            RunningMenu = true; // en bool för att hålla menyn igång

            while (RunningMenu == true) // övertydligt, går att ha while(menybool)
            {
                Console.Clear();
                Console.SetCursorPosition((Console.WindowWidth / 2), 20);
                Console.Write("\n\nVälkommen till Semla Snake!" + // \n är ny rad, \t är tab, flyttar texten något mot mitten
                    "\n\t1. Avsluta programmet" +
                    "\n\t2. Kör skiten");
                ShowBaner(snakeBaner, banerY);

                int menyVal = int.Parse(Console.ReadLine()); // Det du matar in, väljer case via int menyVal.
                switch (menyVal) // Vad som händer väljer man med en siffra, därav case siffra.
                {
                    case 1: // Om menyVal är siffran 1, aktiveras case 1 dvs denna, avslutar programmet.

                        RunningMenu = false; // bool blir false
                        Environment.Exit(1); // såhär avslutar man programmet

                        break; // break, den slutar med case 1 här och i det här fallet är programmet avslutat
                               // i de andra fallen återgår den till koden som skriver ut menyvalen igen eftersom det är en while-loop.

                    case 2: // Om menyVal är en 2a, blir det detta som aktiveras.
                        // skriv ut lite svordomar eller svordomar light beroende på inmatad ålder

                        RunningMenu = false;

                        break;
                }
Console.ReadKey();// texten står kvar tills en tangent trycks

//break;
                   
                    // Det går att köra en meny med IF(menyval == 1) osv men med case blir koden lättare och luftigare, lite grann som en Ölandsvilla i Oktober.
                }
            }
        }
    }

