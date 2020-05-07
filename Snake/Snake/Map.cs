using System;


namespace Snake
{
    //TODO Redo map with console window
    public class Map
    {
        private static int _hight = 41;
        private static int _width = 105;
        private static int textLeft = 72;
        public static FunFunctions Write = new FunFunctions();
        
        
        
        
       private static void Board()
        { 
            
            var wall = new Items();
            Console.WindowHeight = _hight;
            Console.WindowWidth = _width;
            
         
           
           
            for (int y =0;y<41;y++){
                wall.Wall(y);
            }
            for (int x = 1; x < 71; x++){
                    
                wall.Wall(x,false);

            }
        }
       

 

        private static void PrintInstruktions()
        {
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Write.TextPostion(textLeft,0,"             SNAKE               ");
            Write.TextPostion(textLeft,1," --------------------------------");
            Write.TextPostion(textLeft,2," Use W,S,A,D keys to move around ");
            //Write.TextPostion(textLeft,3," Use Q for Quit                  "); futer versions maaaybe
           // Write.TextPostion(textLeft,4," Use E for Pause                 ");
            Write.TextPostion(textLeft,3," --------------------------------");
            
        }
        private static void PrintScore(int score)
        { 
           
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Write.TextPostion(textLeft,4,"                                 ");
            Write.TextPostion(textLeft,5,$" Points: {score}                       ");
            for (int i = 6; i < 41; i++)
            {
                Write.TextPostion(textLeft,i,"                                 ");
            }
          
          
           
        }

        public void uppdateScore(int point)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            new FunFunctions().TextPostion(textLeft +9,5 ,point.ToString());
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void StartMap(int score)
        {
            Board();
            PrintInstruktions();
            PrintScore(score);
        }
    }
}