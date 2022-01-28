using static SnakeTest3.Snake;

namespace SnakeTest3
{
    internal class LogicA
    {

        public void Logic()
        {
            if (X[0] == fruitX)
            {
                if (Y[0] == fruitY)
                {
                    Parts++;
                    score += 100;
                    fruitX = rnd.Next(2, Width - 2); // drawing the position of the fruit
                    fruitY = rnd.Next(2, Height - 2); // drawing the position of the fruit
                    WriteScore();                                 // 


                }
            }
            for (int i = Parts; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];

            }

            switch (key)
            {
                case 'w':
                    Y[0]--;
                    break;
                case 's':
                    Y[0]++;
                    break;
                case 'd':
                    X[0]++;
                    break;
                case 'a':
                    X[0]--;
                    break;
            }

            if (X[0] <=2 || X[0] >= 48 || Y[0] <= 2 || Y[0] >= 22)
            {
                Lost = true;
            }

            for (int i = Parts; i > 2;i--)
            {
                if (X[0] == X[i-1] && Y[0] == Y[i - 1])
                {
                    Lost = true;
                }
            }

            for (int i = 0; i <= Parts - 1; i++) // snake drawing 
            {
                WritePoint(X[i], Y[i]);
                WritePoint(fruitX, fruitY);
            }
            Thread.Sleep(100);
        }
    }
}
