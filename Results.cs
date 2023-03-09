using System;

class Results : ExtraMethods
{ 

   //LOSE, WIN AND TIE METHODS
   static void Lose()
   { 

       Console.ReadKey(true);

       Console.Clear();
       Console.ForegroundColor = ConsoleColor.Red;
       Console.WriteLine(@"
██       ██████  ███████ ███████                     ██ 
██      ██    ██ ██      ██                      ██ ██  
██      ██    ██ ███████ █████                      ██  
██      ██    ██      ██ ██                      ██ ██  
███████  ██████  ███████ ███████                     ██		       
		       ");

   }

   static void Win()
   { 

      Console.ReadKey(true);

      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine(@"
██     ██ ██ ███    ██                    ██  
██     ██ ██ ████   ██                 ██  ██ 
██  █  ██ ██ ██ ██  ██                     ██ 
██ ███ ██ ██ ██  ██ ██                 ██  ██ 
 ███ ███  ██ ██   ████                    ██
                        ");

   }

   static void Tie()
   { 
       
      Console.ReadKey(true);

      Console.Clear();
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine(@"
████████ ██ ███████                        ██ 
   ██    ██ ██                      ██    ██  
   ██    ██ █████                        ██   
   ██    ██ ██                      ██  ██    
   ██    ██ ███████                    ██
                        ");

   }




   //METHODS THAT CHECK FOR WIN, LOSE AND TIE PATTERNS
   public static bool CheckLose()
   {

       bool lost = false;

       //HORIZONTAL PATTERNS 
       if ( AIposOnePlayed && AIposTwoPlayed && AIposThreePlayed )
       { Lose(); lost = true; }

       if ( AIposFourPlayed && AIposFivePlayed && AIposSixPlayed )
       { Lose(); lost = true; }

       if ( AIposSevenPlayed && AIposEightPlayed && AIposNinePlayed )
       { Lose(); lost = true; }


       //VERTICAL PATTERNS
       if ( AIposOnePlayed && AIposFourPlayed && AIposSevenPlayed )
       { Lose(); lost = true; }
       
       if ( AIposTwoPlayed && AIposFivePlayed && AIposEightPlayed )
       { Lose(); lost = true; } 

       if ( AIposThreePlayed && AIposSixPlayed && AIposNinePlayed )
       { Lose(); lost = true; }


       //DIAGONAL PATTERNS
       if ( AIposOnePlayed && AIposFivePlayed && AIposNinePlayed )
       { Lose(); lost = true; }

       if ( AIposThreePlayed && AIposFivePlayed && AIposSevenPlayed )
       { Lose(); lost = true; }


       return lost;

   }

   
   public static bool CheckWin()
   { 

       bool won = false;

       //HORIZONTAL PATTERNS 
       if ( posOnePlayed && posTwoPlayed && posThreePlayed )
       { Win(); won = true; }

       if ( posFourPlayed && posFivePlayed && posSixPlayed )
       { Win(); won = true; }

       if ( posSevenPlayed && posEightPlayed && posNinePlayed )
       { Win(); won = true; }


       //VERTICAL PATTERNS
       if ( posOnePlayed && posFourPlayed && posSevenPlayed )
       { Win(); won = true; }
       
       if ( posTwoPlayed && posFivePlayed && posEightPlayed )
       { Win(); won = true; } 

       if ( posThreePlayed && posSixPlayed && posNinePlayed )
       { Win(); won = true; }


       //DIAGONAL PATTERNS
       if ( posOnePlayed && posFivePlayed && posNinePlayed )
       { Win(); won = true; }

       if ( posThreePlayed && posFivePlayed && posSevenPlayed )
       { Win(); won = true; }


       return won;
  
   }

   public static bool CheckTie()
   { 
       if ( 
            (posOnePlayed || AIposOnePlayed) &&
            (posTwoPlayed || AIposTwoPlayed) &&
	    (posThreePlayed || AIposThreePlayed) &&
	    (posFourPlayed || AIposFourPlayed) &&
	    (posFivePlayed || AIposFivePlayed) &&
	    (posSixPlayed || AIposSixPlayed) &&
	    (posSevenPlayed || AIposSevenPlayed) &&
	    (posEightPlayed || AIposEightPlayed) &&
	    (posNinePlayed || AIposNinePlayed) 
	                  && 

	      ( !CheckLose() && !CheckWin() )
	  )

          { Tie(); return true; }
          else { return false; }


   }



   //"FINAL" METHOD THAT GETS USED BY OTHER SCRIPTS
   public static void WinLoseDraw()
   { 

       if ( CheckLose() == false )
       { 
          if ( CheckWin() == false )
	  { CheckTie(); }
       }

   }

}
