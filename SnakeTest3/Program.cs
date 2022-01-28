
/*
 
****************************
Serously Cool Snake Game 1.0
****************************

TODOS:
- lägga till minor som ger 100 minuspoäng
- lägga till startmeny + avsluta-funktion med "vill du verkligen avsluta)
- lägga till användarregistrering + inloggning + admin
- lägga till higscore-lista
- göra så att det inte blinkar
- göra så att masken ökar i hastighet allt eftersom den växer större
- göra så att det inte går att få negativ längd på masken... 


DONE TODOS:
- När utanför, börja igen på random plats istället för fixed
- När utanför, ge 100 minuspoäng


*/

namespace SnakeTest3
{

    public class Snake
    {
        private static int height = 20;
        private static int width = 50;

        private static int[] x = new int[50];
        private static int[] y = new int[50];

        public static int fruitX;
        public static int fruitY;

        private static int parts = 4;
        public static int score;

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        public static char key = 'W';

        public static Random rnd = new Random();

        private static bool lost;
        public static int top;
        public static int left;

        public static int Height { get => height; set => height = value; }
        public static int Width { get => width; set => width = value; }
        public static int[] X { get => x; set => x = value; }
        public static int[] Y { get => y; set => y = value; }
        public static int Parts { get => parts; set => parts = value; }
        public static bool Lost { get => lost; set => lost = value; }
        public static bool RunningMenu;
        public static int banerY = 2;

        Snake()
        {
            X[0] = rnd.Next(5, Width - 5); ;
            Y[0] = rnd.Next(5, Height - 5); ;
            Console.CursorVisible = false;
            fruitX = rnd.Next(2, Width - 2); // the position of the fruit
            fruitY = rnd.Next(2, Height - 2); // ||
            Lost = false;
        }



        public void Input()
        {

            if (Lost)
            {
                Snake snake = new Snake();
                snake.Input();
                Snake.parts--;
                Snake.score -= 100;


            }

            if (Console.KeyAvailable) // if keypress
            {
                keyInfo = Console.ReadKey(true); //  gets the key from the keyboard
                key = keyInfo.KeyChar;
            }
        }



        public static void WritePoint(int x, int y) // draws a single segment of the snake
        {

            Console.SetCursorPosition(x, y); // sets cursor
            Console.Write("■");
            //GetPosition();



        }

        public static void GetPosition()
        {
            left = Console.CursorLeft;
            top = Console.CursorTop;
            Console.Write(left + "/" + top);
        }

        public static void WriteScore()
        {
            Console.SetCursorPosition(1, 1);
            Console.Write("points: " + score);
        }


        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 30);
            Meny menu = new Meny();

            




            Lost = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Snake snake = new Snake();
            NewWriteBoard DaBoard = new NewWriteBoard();
            LogicA DaLogic = new LogicA();
            
            menu.Dameny();
            
            while (true)
            {

                DaBoard.WriteBoard();
                
                snake.Input();
                DaLogic.Logic();
                
            }
            Console.ReadKey();
        }
    }

}