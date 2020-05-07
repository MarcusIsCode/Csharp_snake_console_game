using System;

namespace Snake
{
    public class Items
    {
        public void SnakeHead(int points, int[] xIn , int[] yIn, out int[] xOut, out int[] yOut)
        {
           
            Console.SetCursorPosition(xIn[0],yIn[0]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((char)214);
            for (int i = 0; i < points+1; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                new FunFunctions().TextPostion(xIn[i], yIn[i], "o");
                            
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            new FunFunctions().TextPostion(xIn[points+1], yIn[points+1], " ");

            for (int i = points+1; i >0; i--)
            {
                xIn[i] = xIn[i - 1];
                yIn[i] = yIn[i - 1];
            }


            xOut = xIn;
            yOut = yIn;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void apple(int Ax, int Ay)
        {
            Console.ForegroundColor =ConsoleColor.Red;
            new FunFunctions().TextPostion(Ax, Ay, "@");

        }
        public void Wall(int i, bool yorX =true)
        {
            if (yorX)
            {
                //this is x-axis -----
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0,i);
                Console.Write("#");
                Console.SetCursorPosition(70,i);
                Console.Write("#");
            } else{
                //this is Y-axis ^
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(i,0);
                Console.Write("#");
                Console.SetCursorPosition(i,40);
                Console.Write("#");
            } 
            
        }
    }
}