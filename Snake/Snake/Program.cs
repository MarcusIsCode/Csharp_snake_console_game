using System;
using System.Data;
using System.Timers;

namespace Snake
{
    class Program
    {
    
        static void Main(string[] args)
        {
            const int StartX = 35;
            const int StartY = 20;

            int[] positionX = new int[2500];
            positionX[0] = StartX;
            
            int[] positionY = new int [2500];
            positionY[0] = StartY;
            
            var randX = new FunFunctions().random(70);
            var randY = new FunFunctions().random(40);

            var points = 0;

            int gameSpeed = 130;
            var wallDeath = false;
            var appleEaten = false;
            var isGameon = true;
            var wallCheck = new FunFunctions();
         
            var map = new Map();
            var cursor = new FunFunctions();
            var snake = new Items();
            var apple = new Items();

            Console.CursorVisible = false;
       
            
            
            map.StartMap(points);
           
            Console.BackgroundColor = ConsoleColor.Black;
           
            apple.apple(randX,randY);
            snake.SnakeHead(points,positionX, positionY,out positionX, out positionY);
           
            ConsoleKey command = Console.ReadKey().Key;


            while (isGameon)
            {
                
                        
                switch (command)
                {
                    case ConsoleKey.A:
                        cursor.TextPostion(positionX[0],positionY[0]," ");
                        positionX[0]--;
                        break;
                        
                    case ConsoleKey.D:
                        cursor.TextPostion(positionX[0],positionY[0], " ");
                        positionX[0]++;
                        break;
                
                    case ConsoleKey.S:
                        cursor.TextPostion(positionX[0], positionY[0], " ");
                        positionY[0]++;
                        break;
                        
                    case ConsoleKey.W:
                        cursor.TextPostion(positionX[0], positionY[0], " ");
                        positionY[0]--;
                        break;
                    
                }
                snake.SnakeHead(points,positionX, positionY ,out positionX, out positionY);
                wallDeath =  wallCheck.WallHit(positionX[0], positionY[0]);
                appleEaten = FunFunctions.ifAppleEaten(positionX[0], positionY[0], randX, randY);
                
                if (wallDeath)
                {
                    isGameon = false;
                    var end = new FunFunctions();
                    end.wallEnd( StartX, StartY,points);
                }


                if (appleEaten)
                {
                    randX = new FunFunctions().random(70);
                    randY = new FunFunctions().random(40);
                    apple.apple(randX,randY);
                    points++;
                    new Map().uppdateScore(points);
                    
                }     
                
                
                if (Console.KeyAvailable) command = Console.ReadKey().Key;
                System.Threading.Thread.Sleep(gameSpeed);

            }

          

        }
     
    }
}