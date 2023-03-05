using System;

class ArtificialDumbness : ExtraMethods
{

    static byte randomPosDrawAmount = 0;

    //This byte is here to fix a stackoverflow exception in the "DrawRandomPosition()" method
    static byte loopRandomDraw = 9;



 


    public static void DefenseAI()
    {

      Console.ForegroundColor = ConsoleColor.Red;

      bool patternFound = false;

/*
      //For the first turn, the AI will play randomly
      if (randomPosDrawAmount < 1) 
      {
      DrawRandomPosition();
      randomPosDrawAmount+=2;
      }
 */     


      // Horizontal 'Almost Wins'
      if ( (posOnePlayed && posTwoPlayed) ) 
      {

         //Checks if the AI already played that position
         if ( !posThreePlayed && !AIposThreePlayed )
         {

         DrawEnemy( (int)PosX.Right, (int)PosY.Top );

         AIposThreePlayed = true;
	 patternFound = true;

         }
         
      }



      if ( (posTwoPlayed && posThreePlayed) )
      {

         if ( !posOnePlayed && !AIposOnePlayed )
         {

          DrawEnemy( (int)PosX.Left, (int)PosY.Top );

          AIposOnePlayed = true;
	  patternFound = true;

         }

      }



      if ( (posFourPlayed && posFivePlayed) )
      {
         if ( !posSixPlayed && !AIposSixPlayed )
         {

         DrawEnemy( (int)PosX.Right, (int)PosY.Middle );

         AIposSixPlayed = true;
	 patternFound = true;

         }

      }



      if ( (posFivePlayed && posSixPlayed) )
      {
         if ( !posFourPlayed && !AIposFourPlayed )
         {

         DrawEnemy( (int)PosX.Left, (int)PosY.Middle );

         AIposFourPlayed = true;
	 patternFound = true;

         }

      }



      if ( (posSevenPlayed && posEightPlayed) )
      {
         if ( !posNinePlayed && !AIposNinePlayed )
         {

         DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

         AIposNinePlayed = true;
	 patternFound = true;

         }
         
      }
      


      if ( (posEightPlayed && posNinePlayed) )
      {
         if ( !posSevenPlayed && !AIposSevenPlayed )
         {

         DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );

         AIposSevenPlayed = true;
	 patternFound = true;

         }

      }



      if ( (posOnePlayed && posThreePlayed) )
      {
         if ( !posTwoPlayed && !AIposTwoPlayed )
         {

         DrawEnemy( (int)PosX.Middle, (int)PosY.Top );

         AIposTwoPlayed = true;
	 patternFound = true;

         }

      }



      if ( (posFourPlayed && posSixPlayed) )
      {
         if ( !posFivePlayed && !AIposFivePlayed )
         {

         DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );

         AIposFivePlayed = true;
	 patternFound = true;

         }

      }
      


      if ( (posSevenPlayed && posNinePlayed) )
      {
         if ( !posEightPlayed && !AIposEightPlayed )
         {

         DrawEnemy( (int)PosX.Middle, (int)PosY.Bottom );

         AIposEightPlayed = true;
	 patternFound = true;

         }

      }





      //Vertical 'Almost Wins'
      if ( (posOnePlayed && posFourPlayed) )
      {
         if ( !posSevenPlayed && !AIposSevenPlayed )
         {

         DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );

         AIposSevenPlayed = true;
	 patternFound = true;

         }

      }



      if ( (posTwoPlayed && posFivePlayed) )
      { 
         if ( !posEightPlayed && !AIposEightPlayed )
         {

         DrawEnemy( (int)PosX.Middle, (int)PosY.Bottom );

         AIposEightPlayed = true;
	 patternFound = true;

         }

      } 



      if ( (posThreePlayed && posSixPlayed) )
      {
         if ( !posNinePlayed && !AIposNinePlayed )
         {

         DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

         AIposNinePlayed = true;
	 patternFound = true;

         }

      }



      if ( (posFourPlayed && posSevenPlayed) )
      {
         if ( !posOnePlayed && !AIposOnePlayed )
         {

         DrawEnemy( (int)PosX.Left, (int)PosY.Top );

         AIposOnePlayed = true;
	 patternFound = true;

         }

      }



      if ( (posFivePlayed && posEightPlayed) )
      {
         if ( !posTwoPlayed && !AIposTwoPlayed )
         {

         DrawEnemy( (int)PosX.Middle, (int)PosY.Top );

         AIposTwoPlayed = true;
	 patternFound = true;

         }

      }



      if ( (posSixPlayed && posNinePlayed) )
      {
         if ( !posThreePlayed && !AIposThreePlayed )
         {

         DrawEnemy( (int)PosX.Right, (int)PosY.Top );

         AIposThreePlayed = true;
	 patternFound = true;

         }

      }



      if ( (posOnePlayed && posSevenPlayed) )
      {
         if ( !posFourPlayed && !AIposFourPlayed )
         {

         DrawEnemy( (int)PosX.Left, (int)PosY.Middle );

         AIposFourPlayed = true;
	 patternFound = true;

         }

      }



      if ( (posTwoPlayed && posEightPlayed) )
      {
         if ( !posFivePlayed && !AIposFivePlayed )
         {

         DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );

         AIposFivePlayed = true;
	 patternFound = true;

         }

      }



      if ( (posThreePlayed && posNinePlayed) )
      {
         if ( !posSixPlayed && !AIposSixPlayed )
         {

         DrawEnemy( (int)PosX.Right, (int)PosY.Middle );

         AIposSixPlayed = true;
	 patternFound = true;

         }

      }





      //Diagonal 'Almost Wins'
      if ( (posOnePlayed && posFivePlayed) )
      {
         if ( !posNinePlayed && !AIposNinePlayed )
         {

           DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

           AIposNinePlayed = true;
	   patternFound = true;

         }

      }



      if ( (posThreePlayed && posFivePlayed) )
      {
         if ( !posSevenPlayed && !AIposSevenPlayed )
         {

           DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );

           AIposSevenPlayed = true;
	   patternFound = true;

         }

      }



      if ( (posSevenPlayed && posFivePlayed) )
      { 
         if ( !posThreePlayed && !AIposThreePlayed )
         {

            DrawEnemy( (int)PosX.Right, (int)PosY.Top );

            AIposThreePlayed = true;
	    patternFound = true;

         }
        
      }
  


      if ( (posNinePlayed && posFivePlayed) )
      {
         if ( !posOnePlayed && !AIposOnePlayed )
         {

            DrawEnemy( (int)PosX.Left, (int)PosY.Top );

            AIposOnePlayed = true;
	    patternFound = true;

         }

      }



      //IF THERE'S NO DEFENSE PATTERNS FOUND, ( LIKE ON THE FIRST TURN, OR SPECIFIC SITUATIONS ), THEN IT PLAYS RANDOMLY
      if ( patternFound == false )
      { DrawRandomPosition(); } 

      Console.ForegroundColor = ConsoleColor.Cyan; 



    }






    public static bool AttackAI()
    { 

        Console.ForegroundColor = ConsoleColor.Red;

	//THIS BOOL RETUNRS TRUE IF THE METHOD FINDS AN ATTACK PATTERN
	bool patternFound = false;


        //Horizonal Patterns:
	
	//POS 1
	if ( AIposTwoPlayed && AIposThreePlayed )
	{ 
	    if ( !posOnePlayed && !AIposOnePlayed )
	    { 
	       DrawEnemy( (int)PosX.Left, (int)PosY.Top );

	       AIposOnePlayed = true; 
	       patternFound = true;
	    }
	}


	//POS 2
	if ( AIposOnePlayed && AIposThreePlayed )
	{ 
	   if ( !posTwoPlayed && !AIposTwoPlayed )
	   { 
	       DrawEnemy( (int)PosX.Middle, (int)PosY.Top );

	       AIposTwoPlayed = true;
	       patternFound = true;
	   }
	}

	//POS 3
	if ( AIposOnePlayed && AIposTwoPlayed )
	{ 
	   if ( !posThreePlayed && !AIposThreePlayed )
	   { 
	      DrawEnemy( (int)PosX.Right, (int)PosY.Top );

	      AIposThreePlayed = true;
	      patternFound = true;
	   }
	}

	//POS 4
	if ( AIposFivePlayed && AIposSixPlayed )
	{ 
	   if ( !posFourPlayed && !AIposFourPlayed )
	   { 
	      DrawEnemy( (int)PosX.Left, (int)PosY.Middle );

	      AIposFourPlayed = true;
	      patternFound = true;
	   }
	}

	//POS 5
	if ( AIposFourPlayed && AIposSixPlayed )
	{ 
	   if ( !posFivePlayed && !AIposFivePlayed )
	   { 
	      DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );

	      AIposFivePlayed = true;
	      patternFound = true;
	   }
	}

	//POS 6
	if ( AIposFourPlayed && AIposFivePlayed )
	{ 
	   if ( !posSixPlayed && !AIposSixPlayed )
	   { 
	      DrawEnemy( (int)PosX.Right, (int)PosY.Middle );

	      AIposSixPlayed = true;
	      patternFound = true;
	   }
	}

	//POS 7
	if ( AIposEightPlayed && AIposNinePlayed )
	{ 
	   if ( !posSevenPlayed && !AIposSevenPlayed )
	   { 
	      DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );

	      AIposSevenPlayed = true;
	      patternFound = true;
	   }
	}

	//POS 8
	if ( AIposSevenPlayed && AIposNinePlayed )
	{ 
	   if ( !posEightPlayed && !AIposEightPlayed )
	   { 
	      DrawEnemy( (int)PosX.Middle, (int)PosY.Bottom );

	      AIposEightPlayed = true;
	      patternFound = true;
	   }
	}

	//POS 9
	if ( AIposSevenPlayed && AIposEightPlayed )
	{ 
	   if ( !posNinePlayed && !AIposNinePlayed )
	   { 
	      DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

              AIposNinePlayed = true;
	      patternFound = true;
	   }
	}

	
	//Vertical Patterns
	
	//POS 1
	if ( AIposFourPlayed && AIposSevenPlayed )
	{ 
	   if ( !posOnePlayed && !AIposOnePlayed )
	   { 
	      DrawEnemy( (int)PosX.Left, (int)PosY.Top );

	      AIposOnePlayed = true;
	      patternFound = true;
	   }
	}

	//POS 2
	if (AIposFivePlayed && AIposEightPlayed )
	{ 
	   if ( !posTwoPlayed && !AIposTwoPlayed )
	   { 
	      DrawEnemy( (int)PosX.Middle, (int)PosY.Top );

	      AIposTwoPlayed = true;
	      patternFound = true;
	   }
	}

	//POS 3
	if ( AIposSixPlayed && AIposNinePlayed )
	{ 
	   if ( !posThreePlayed && !AIposThreePlayed )
	   { 
	      DrawEnemy( (int)PosX.Right, (int)PosY.Top );

	      AIposThreePlayed = true;
	      patternFound = true;
	   }
	}

	//POS 4
	if ( AIposOnePlayed && AIposSevenPlayed )
	{ 
	   if ( !posFourPlayed && !AIposFourPlayed )
	   { 
	      DrawEnemy( (int)PosX.Left, (int)PosY.Middle );

	      AIposFourPlayed = true;
	      patternFound = true;
	   }
	}

	//POS 5
	if ( AIposTwoPlayed && AIposEightPlayed )
	{ 
	   if ( !posFivePlayed && !AIposFivePlayed )
	   { 
	      DrawEnemy ( (int)PosX.Middle, (int)PosY.Middle );

	      AIposFivePlayed = true;
	      patternFound = true;
	   }
	}

	//POS 6
	if ( AIposThreePlayed && AIposNinePlayed )
	{ 
	   if ( !posSixPlayed && !AIposSixPlayed )
	   { 
	      DrawEnemy( (int)PosX.Right, (int)PosY.Middle );

	      AIposSixPlayed = true;
	      patternFound = true;
	   }
	}

	//POS 7
	if ( AIposOnePlayed && AIposFourPlayed )
	{ 
	   if ( !posSevenPlayed && !AIposSevenPlayed )
	   { 
	      DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );

              AIposSevenPlayed = true;
	      patternFound = true;
	   }
	}

	//POS 8
	if ( AIposTwoPlayed && AIposFivePlayed )
	{ 
	   if ( !posEightPlayed && !AIposEightPlayed )
	   { 
	      DrawEnemy( (int)PosX.Middle, (int)PosY.Bottom );

	      AIposEightPlayed = true;
	      patternFound = true;
	   }
	}

	//POS 9
	if ( AIposThreePlayed && AIposSixPlayed )
	{ 
	   if ( !posNinePlayed && !AIposNinePlayed )
	   { 
	      DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

	      AIposNinePlayed = true;
	      patternFound = true;
	   }
	}

	
	//Diagonal Patterns

	//POS 1
	if ( AIposFivePlayed && AIposNinePlayed )
	{ 
	   if ( !posOnePlayed && !AIposOnePlayed )
	   { 
	      DrawEnemy( (int)PosX.Left, (int)PosY.Top );

	      AIposOnePlayed = true;
	      patternFound = true;
	   }
	}

	//POS 3
	if ( AIposFivePlayed && AIposSevenPlayed )
	{ 
	   if ( !posThreePlayed && !AIposThreePlayed )
	   { 
	      DrawEnemy( (int)PosX.Right, (int)PosY.Top );

	      AIposThreePlayed = true;
	      patternFound = true;
	   }
	}

	//POS 7
	if ( AIposFivePlayed && AIposThreePlayed )
	{ 
	   if ( !posSevenPlayed && !AIposSevenPlayed )
	   { 
	      DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );

	      AIposSevenPlayed = true;
	      patternFound = true;
	   }
	}

	//POS 9
	if ( AIposFivePlayed && AIposOnePlayed )
	{ 
	   if ( !posNinePlayed && !AIposNinePlayed )
	   { 
	      DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );

	      AIposNinePlayed = true;
	      patternFound = true;
	   }
	}

	return patternFound;
    }






    //Draws the enemy at a random position of the tic-tac-toe board
    static void DrawRandomPosition()
    {

      int randomNum = new Random().Next(1, 10);
      
      //POS 1
      if ( (randomNum == 1) )
      {

         //Checks if the position hasn't been taken
         if ( !posOnePlayed && !AIposOnePlayed )
         {

          DrawEnemy( (int)PosX.Left, (int)PosY.Top );
          AIposOnePlayed = true;
          loopRandomDraw = 9;

         }

         //If the position is already taken, it resets the method
         else
         {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }


      //POS 2
      else if ( (randomNum == 2) )
      {
         if ( !posTwoPlayed && !AIposTwoPlayed )
         {

          DrawEnemy( (int)PosX.Middle, (int)PosY.Top );
          AIposTwoPlayed = true;
          loopRandomDraw = 9;

         }

         else
         {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }


      //POS 3
      else if ( (randomNum == 3) )
      {
         if ( !posThreePlayed && !AIposThreePlayed )
         {

             DrawEnemy( (int)PosX.Right, (int)PosY.Top );
             AIposThreePlayed = true;
             loopRandomDraw = 9;

         }

         else 
         {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }
         
      }

      //POS 4
      else if ( (randomNum == 4 ) )
      {
         if ( !posFourPlayed && !AIposFourPlayed )
         {

             DrawEnemy( (int)PosX.Left, (int)PosY.Middle );
             AIposFourPlayed = true;
             loopRandomDraw = 9;

         }

         else 
         {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

      //POS 5
      else if ( (randomNum == 5) )
      {
         if ( !posFivePlayed && !AIposFivePlayed )
         {

             DrawEnemy( (int)PosX.Middle, (int)PosY.Middle );
             AIposFivePlayed = true;
             loopRandomDraw = 9;

         }

         else 
         {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

      //POS 6
      else if ( (randomNum == 6) )
      {
          if ( !posSixPlayed && !AIposSixPlayed )
          {

             DrawEnemy( (int)PosX.Right, (int)PosY.Middle );
             AIposSixPlayed = true;
             loopRandomDraw = 9;

          }

          else 
          {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

      //POS 7
      else if ( (randomNum == 7) )
      {
          if ( !posSevenPlayed && !AIposSevenPlayed )
          {

             DrawEnemy( (int)PosX.Left, (int)PosY.Bottom );
             AIposSevenPlayed = true;
             loopRandomDraw = 9;

          }

          else 
          {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

      //POS 8
      else if ( (randomNum == 8) )
      {
          if ( !posEightPlayed && !AIposEightPlayed )
          {

             DrawEnemy( (int)PosX.Middle, (int)PosY.Bottom );
             AIposEightPlayed = true;
             loopRandomDraw = 9;

          }

          else 
          {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

      //POS 9
      else if ( (randomNum == 9) )
      {
          if ( !posNinePlayed && !AIposNinePlayed )
          {

             DrawEnemy( (int)PosX.Right, (int)PosY.Bottom );
             AIposNinePlayed = true;
             loopRandomDraw = 9;

          }

          else 
          {   if ( loopRandomDraw > 0 ) { loopRandomDraw--; DrawRandomPosition(); }   }

      }

    }


    static void DrawEnemy( int PosX, int PosY )
    {

          Console.SetCursorPosition(PosX, PosY);

          if ( !DrawingPlayer.circle )
          { DrawCircle(); }

          else 
          { DrawX(); }
    }
}
