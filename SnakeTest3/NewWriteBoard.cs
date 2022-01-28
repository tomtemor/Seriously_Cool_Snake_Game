using static SnakeTest3.Snake;

namespace SnakeTest3
{
    internal class NewWriteBoard
    {

        public void WriteBoard()
        {
           // Console.SetWindowSize(60, 30);
            Console.Clear();
           
            
            for (int i = 1; i <= (Width + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
                


            }
            for (int i = 1; i <= (Width + 2); i++)
            {
                Console.SetCursorPosition(i, Height + 2);
                Console.Write("-");
                Console.WriteLine("                ");
                Console.WriteLine("Score: " + score);
                Console.WriteLine("                ");
                Console.WriteLine("Snake Parts: " + Parts);
                Console.WriteLine("                ");

                GetPosition();

            }

            for (int i = 1; i <= (Height + 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }

            for (int i = 1; i <= Height + 1; i++)
            {
                Console.SetCursorPosition((Width + 2), i);
                Console.Write("|");


            }

            // blank writes
            

            //for (int i = 1; i <= Snake.Height + 1; i++)
            //{
            //    Console.SetCursorPosition((Snake.Width + 2), i);
            //    Console.Write(" ");

            //}
            



        }
    }
}
