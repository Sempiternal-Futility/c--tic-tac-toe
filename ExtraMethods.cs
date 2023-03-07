using System;

class ExtraMethods
{

    public enum PosX
    {
        //Left Positions (x axis)
        Left = 12,
        Middle = 44,
        Right = 74,

    }

    public enum PosY
    {
        //Top Positions (y axis)
        Top = 7,
        Middle = 22,
        Bottom = 37
    }



      //The reason that "+ 2" is in every "PosX" is because the string "playerMarker" is 2 chars long, so this "+ 2" even things things out
      public static (int Left, int Top) posOne = ( (int)PosX.Left + 2, (int)PosY.Top );
      public static (int Left, int Top) posTwo = ( (int)PosX.Middle + 2, (int)PosY.Top );
      public static (int Left, int Top) posThree = ( (int)PosX.Right + 2, (int)PosY.Top );
      public static (int Left, int Top) posFour = ( (int)PosX.Left + 2, (int)PosY.Middle );
      public static (int Left, int Top) posFive = ( (int)PosX.Middle + 2, (int)PosY.Middle );
      public static (int Left, int Top) posSix = ( (int)PosX.Right + 2, (int)PosY.Middle );
      public static (int Left, int Top) posSeven = ( (int)PosX.Left + 2, (int)PosY.Bottom );
      public static (int Left, int Top) posEight = ( (int)PosX.Middle + 2, (int)PosY.Bottom );
      public static (int Left, int Top) posNine = ( (int)PosX.Right + 2, (int)PosY.Bottom );


     //Player positions
     public static bool posOnePlayed = false;
     public static bool posTwoPlayed = false;
     public static bool posThreePlayed = false;
     public static bool posFourPlayed = false;
     public static bool posFivePlayed = false;
     public static bool posSixPlayed = false;
     public static bool posSevenPlayed = false;
     public static bool posEightPlayed = false;
     public static bool posNinePlayed = false;



    //AI positions
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

/*
    public static void DrawCharacter()
    {

      if ( DrawingPlayers.circle )
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
      
      else
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
 

        //The reasons i didn't use a string literal to draw the circle, is because if i used a literal, i wouldn't be able to change its position
        //So instead, i wrote it line by line without a literal
    }
*/

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


   //This method checks if the match is over by checking the bools of the player and the AI
   public static bool CheckIfMatchIsOver()
   {

         if ( Results.CheckTie() || Results.CheckLose() || Results.CheckWin() )

         { return true; }   
         else { return false; }

   }



   //This method is used when the player tries to overlap either it's own or the enemy's position
   public static void ResetMarker()
   {
      DrawingPlayer.EraseMarker(); 
      DrawingPlayer.DrawMarker( 44, 22); 
      Console.Beep(); 
   }

}
