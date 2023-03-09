using System;
using System.Threading;

class ExtraMethods
{

    public enum PosX
    {
        //LEFT POSITIONS (x axis)
        Left = 12,
        Middle = 44,
        Right = 74,

    }

    public enum PosY
    {
        //TOP POSITIONS (y axis)
        Top = 7,
        Middle = 22,
        Bottom = 37
    }



      //THE REASON THAT "+ 2" IS IN EVERY "PosX" IS BECAUSE THE STRING "playerMarker" IS 2 CHARS LONG, SO THIS "+ 2" EVEN THINGS OUT
      public static (int Left, int Top) posOne = ( (int)PosX.Left + 2, (int)PosY.Top );
      public static (int Left, int Top) posTwo = ( (int)PosX.Middle + 2, (int)PosY.Top );
      public static (int Left, int Top) posThree = ( (int)PosX.Right + 2, (int)PosY.Top );
      public static (int Left, int Top) posFour = ( (int)PosX.Left + 2, (int)PosY.Middle );
      public static (int Left, int Top) posFive = ( (int)PosX.Middle + 2, (int)PosY.Middle );
      public static (int Left, int Top) posSix = ( (int)PosX.Right + 2, (int)PosY.Middle );
      public static (int Left, int Top) posSeven = ( (int)PosX.Left + 2, (int)PosY.Bottom );
      public static (int Left, int Top) posEight = ( (int)PosX.Middle + 2, (int)PosY.Bottom );
      public static (int Left, int Top) posNine = ( (int)PosX.Right + 2, (int)PosY.Bottom );


     //PLAYER BOOL POSITIONS
     public static bool posOnePlayed = false;
     public static bool posTwoPlayed = false;
     public static bool posThreePlayed = false;
     public static bool posFourPlayed = false;
     public static bool posFivePlayed = false;
     public static bool posSixPlayed = false;
     public static bool posSevenPlayed = false;
     public static bool posEightPlayed = false;
     public static bool posNinePlayed = false;



    //AI BOOL POSITIONS
    public static bool AIposOnePlayed = false;
    public static bool AIposTwoPlayed = false;
    public static bool AIposThreePlayed = false;
    public static bool AIposFourPlayed = false;
    public static bool AIposFivePlayed = false;
    public static bool AIposSixPlayed = false;
    public static bool AIposSevenPlayed = false;
    public static bool AIposEightPlayed = false;
    public static bool AIposNinePlayed = false;



    public static void DrawingBoard()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(
            @"
                                                                                        
                           ,---,                          ,---,                         
                         ,---.'|                        ,---.'|                         
                         |   | :                        |   | :                         
                         '   : '                        '   : '                         
                         :   | |                        :   | |                         
                         |   ' :                        |   ' :                         
                         ;   ; |                        ;   ; |                         
                         '   | '                        '   | '                         
                         |   | :                        |   | :                         
         ___         ___ '   : '        ___         ___ '   : '        ___         ___  
      .'  .`|     .'  .`||   | |     .'  .`|     .'  .`||   | |     .'  .`|     .'  .`| 
   .'  .'   :  .'  .'   :;   : ;  .'  .'   :  .'  .'   :;   : ;  .'  .'   :  .'  .'   : 
,---, '   .',---, '   .' |   ,/,---, '   .',---, '   .' |   ,/,---, '   .',---, '   .'  
;   |  .'   ;   |  .'    '---' ;   |  .'   ;   |  .'    '---' ;   |  .'   ;   |  .'     
`---'       `---'              `---'       `---'              `---'       `---'         
                           ,---,                          ,---,                         
                         ,---.'|                        ,---.'|                         
                         |   | :                        |   | :                         
                         '   : '                        '   : '                         
                         :   | |                        :   | |                         
                         |   ' :                        |   ' :                         
                         ;   ; |                        ;   ; |                         
                         '   | '                        '   | '                         
                         |   | :                        |   | :                         
         ___         ___ '   : '        ___         ___ '   : '        ___         ___  
      .'  .`|     .'  .`||   | |     .'  .`|     .'  .`||   | |     .'  .`|     .'  .`| 
   .'  .'   :  .'  .'   :;   : ;  .'  .'   :  .'  .'   :;   : ;  .'  .'   :  .'  .'   : 
,---, '   .',---, '   .' |   ,/,---, '   .',---, '   .' |   ,/,---, '   .',---, '   .'  
;   |  .'   ;   |  .'    '---' ;   |  .'   ;   |  .'    '---' ;   |  .'   ;   |  .'     
`---'       `---'              `---'       `---'              `---'       `---'         
                        ,---,                               ,---,                       
                      ,---.'|                             ,---.'|                       
                      |   | :                             |   | :                       
                      '   : '                             '   : '                       
                      :   | |                             :   | |                       
                      |   ' :                             |   ' :                       
                      ;   ; |                             ;   ; |                       
                      '   | '                             '   | '                       
                      |   | :                             |   | :                       
                      '   : '                             '   : '                       
                      |   | |                             |   | |                       
                      ;   : ;                             ;   : ;                       
                      |   ,/                              |   ,/                        
                      '---'                               '---'                         
            ");

    }


   //THE REASON I JUST DIDNT USE A STRING LITERAL, IS BECAUSE YOU CANT PLACE STRING LITERALS WHEREVER YOU WANT IN THE SCREEN ( with "Console.SetCursorPosition(x, y)" , this just doesnt work with literals )
   public static void DrawCircle()
   {

        int currentPosX = Console.CursorLeft;
        int currentPosY = Console.CursorTop;

        Console.CursorLeft = currentPosX - 5;
        Console.CursorTop = currentPosY - 5;
        Console.WriteLine("   ,---.");

        Console.CursorLeft = currentPosX - 5;
        Console.CursorTop = currentPosY - 4;
        Console.WriteLine("  '   ,'\\"); 

        Console.CursorLeft = currentPosX - 5;
        Console.CursorTop = currentPosY - 3;
        Console.WriteLine(" /   /   |");        

        Console.CursorLeft = currentPosX - 5;
        Console.CursorTop = currentPosY - 2;
        Console.WriteLine(".   ; ,. :");

        Console.CursorLeft = currentPosX - 5;
        Console.CursorTop = currentPosY - 1;
        Console.WriteLine("'   | |: :");
 
        Console.CursorLeft = currentPosX - 5;
        Console.CursorTop = currentPosY;
        Console.WriteLine("'   | .; :");

        Console.CursorLeft = currentPosX - 5;
        Console.CursorTop = currentPosY + 1;
        Console.WriteLine("|   :    |");

        Console.CursorLeft = currentPosX - 5;
        Console.CursorTop = currentPosY + 2;
        Console.WriteLine(" \\   \\  /");

        Console.CursorLeft = currentPosX - 5;
        Console.CursorTop = currentPosY + 3;
        Console.WriteLine("  `----'");

   }
   
   public static void DrawX()
   {

        int currentPosX = Console.CursorLeft;
        int currentPosY = Console.CursorTop;

        Console.CursorLeft = currentPosX - 8;
        Console.CursorTop = currentPosY - 5;
        Console.WriteLine(" ,--,  ,--,");

        Console.CursorLeft = currentPosX - 8;
        Console.CursorTop = currentPosY - 4;
        Console.WriteLine(" |'. \\/ .`|");

        Console.CursorLeft = currentPosX - 8;
        Console.CursorTop = currentPosY - 3;
        Console.WriteLine(" '  \\/  / ;");

        Console.CursorLeft = currentPosX - 8;
        Console.CursorTop = currentPosY - 2;
        Console.WriteLine("  \\  \\.' /");

        Console.CursorLeft = currentPosX - 8;
        Console.CursorTop = currentPosY - 1;
        Console.WriteLine("   \\  ;  ;");
 
        Console.CursorLeft = currentPosX - 8;
        Console.CursorTop = currentPosY;
        Console.WriteLine("  / \\  \\  \\");
  
        Console.CursorLeft = currentPosX - 8;
        Console.CursorTop = currentPosY + 1;
        Console.WriteLine("./__;   ;  \\");
 
        Console.CursorLeft = currentPosX - 8;
        Console.CursorTop = currentPosY + 2;
        Console.WriteLine("|   :/\\  \\ ;");

        Console.CursorLeft = currentPosX - 8;
        Console.CursorTop = currentPosY + 3;
        Console.WriteLine("`---'  `--` ");
 
   }


   //THIS METHOD CHECKS IF THE MATCH IS OVER BY CHECKING THE RETURN VALUE OF THE METHODS INSIDE THE "RESULTS" CLASS
   public static bool CheckIfMatchIsOver()
   {

         if ( Results.CheckTie() || Results.CheckLose() || Results.CheckWin() )

         { return true; }   
         else { return false; }

   }



   //THIS METHOD IS USED WHEN THE PLAYER TRIES TO OVERLAP EITHER HIS OWN OR THE ENEMY'S POSITION
   public static void ResetMarker()
   {
      DrawingPlayer.EraseMarker(); 
      DrawingPlayer.DrawMarker( 44, 22 ); 
      Console.Beep(); 
   }


   public static void ChooseYourCharacter()
   { 
       Console.ForegroundColor = ConsoleColor.White;

       Console.WriteLine(@"
 ██████ ██   ██  ██████   ██████  ███████ ███████    
██      ██   ██ ██    ██ ██    ██ ██      ██      ██ 
██      ███████ ██    ██ ██    ██ ███████ █████      
██      ██   ██ ██    ██ ██    ██      ██ ██      ██ 
 ██████ ██   ██  ██████   ██████  ███████ ███████   

 
                                                   		       
		       ");

       Console.ForegroundColor = ConsoleColor.Cyan;
       Console.WriteLine(@"
   ██████                                       ██   ██         
  ██    ██                                       ██ ██          
  ██    ██                                        ███           
  ██    ██                                       ██ ██          
   ██████                                       ██   ██       
		       ");


       Console.ForegroundColor = ConsoleColor.White;
       Console.WriteLine(@"
███      ███                                 ███      ███     
██        ██                                 ██        ██     
██        ██                                 ██        ██     
██        ██                                 ██        ██     
███      ███                                 ███      ███		       
		       ");

       DrawingPlayer.DrawMarker(5, 20);
      
       while ( 1 > 0 )
       { 

         var currentPos = Console.GetCursorPosition();
         var readInput = Console.ReadKey(true).Key;

	 //MOVEMENT "IF's"
         if ( readInput == ConsoleKey.D )
         { DrawingPlayer.EraseMarker();   DrawingPlayer.DrawMarker(50, 20); }

         if ( readInput == ConsoleKey.A )
         { DrawingPlayer.EraseMarker();  DrawingPlayer.DrawMarker(5, 20); }



	 //CONFIRMATION "IF's"
         if ( readInput == ConsoleKey.Enter && currentPos == (5 + 2, 20) )
         { DrawingPlayer.circle = true; break; }

         if ( readInput == ConsoleKey.Enter && currentPos == (50 + 2, 20) )
         { DrawingPlayer.circle = false; break; }

       }

   }

   public static bool AskPlayAgain()
   { 

       Console.Clear();

       Console.WriteLine(@"
██████  ██       █████  ██    ██              █████   ██████   █████  ██ ███    ██             ██████  
██   ██ ██      ██   ██  ██  ██              ██   ██ ██       ██   ██ ██ ████   ██                  ██ 
██████  ██      ███████   ████               ███████ ██   ███ ███████ ██ ██ ██  ██               ▄███  
██      ██      ██   ██    ██                ██   ██ ██    ██ ██   ██ ██ ██  ██ ██               ▀▀    
██      ███████ ██   ██    ██                ██   ██  ██████  ██   ██ ██ ██   ████               ██


                         ");
       Console.WriteLine(@"
 ██     ██    ██     ██ ███    ██     ██  
██       ██  ██     ██  ████   ██      ██ 
██        ████     ██   ██ ██  ██      ██ 
██         ██     ██    ██  ██ ██      ██ 
 ██        ██    ██     ██   ████     ██
                         ");

       bool repeatSwitch = true;
       bool playAgain = false;

       while ( repeatSwitch )
       { 

           switch ( Console.ReadKey(true).KeyChar )
	   { 

	       case 'y' : repeatSwitch = false; playAgain = true; 
	       break;

               case 'n' : repeatSwitch = false; playAgain = false;
	       break;

	       default : repeatSwitch = true;
	       break;

	   }

       }

       return playAgain;

   }

   public static void LoopProgram()
   { 

       posOnePlayed = false;
       posTwoPlayed = false;
       posThreePlayed = false;
       posFourPlayed = false;
       posFivePlayed = false;
       posSixPlayed = false;
       posSevenPlayed = false;
       posEightPlayed = false;
       posNinePlayed = false;

       AIposOnePlayed = false;
       AIposTwoPlayed = false;
       AIposThreePlayed = false;
       AIposFourPlayed = false;
       AIposFivePlayed = false;
       AIposSixPlayed = false;
       AIposSevenPlayed = false;
       AIposEightPlayed = false;
       AIposNinePlayed = false;

       MainClass.Main();

   }

   public static void ByeEmoticon()
   { 

       Console.Clear();

       for ( byte i = 0; 4 > i; i++ )
       { 

           Console.WriteLine(@"
 ███      ███         ██
██ ██    ██ ██        ██  
                     ██  
                    ██    
      ██           ██	



██████  ██    ██ ███████             ██     ██     ██ 
██   ██  ██  ██  ██                  ██     ██     ██ 
██████    ████   █████               ██     ██     ██ 
██   ██    ██    ██                                   
██████     ██    ███████             ██     ██     ██		   
			    ");


           Thread.Sleep(250);
	   Console.Clear();


	   Console.WriteLine(@"
 ███      ███      ██      
██ ██    ██ ██      ██     
                     ██     
                    ██     
      ██           ██ 	




██████  ██    ██ ███████             ██     ██     ██ 
██   ██  ██  ██  ██                  ██     ██     ██ 
██████    ████   █████               ██     ██     ██ 
██   ██    ██    ██                                   
██████     ██    ███████             ██     ██     ██
		   
			     ");

	   
	   Thread.Sleep(250);
	   Console.Clear();
	   
       }
   }

}
