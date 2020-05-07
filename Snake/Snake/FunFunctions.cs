using System;
using System.Diagnostics;

namespace Snake
{
    public class FunFunctions
    {
        
        
        public void TextPostion(int x, int y, string text)
        {
       
            Console.SetCursorPosition(x,y);
            Console.Write(text);
          
          
        }
        public int random( int num)
        {
            var random  = new Random();
            var result = random.Next(1, num);
            return result;
        }
        public bool WallHit(int x, int y)
        {
            if (x == 0 || x == 70)
            {
                return true;
            }

            if (y == 0 || y == 40)
            {
                return true;
            }
            
            return false;
        }

        public void wallEnd(int startX, int startY ,int score)
        {
            
                var walltext = new FunFunctions();
                Console.ForegroundColor =ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                walltext.TextPostion(startX,startY, "The snake hit the wall");
                walltext.TextPostion(startX, startY+1, "your score:" +score);
                walltext.TextPostion(startX,startY+2,"");
                Console.ReadLine();

        }

        public static bool ifAppleEaten(int Sx, int Sy, int Ax, int Ay)
        {
            if (Sx == Ax && Sy == Ay)
            {
                
                return true;
            }
           
            return false;
            
            
        }

        
        
       
    }
}