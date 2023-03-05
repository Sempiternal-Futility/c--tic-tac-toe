using System;

class DrawingPlayer : ExtraMethods
{
    public static bool circle = false;

    public static void AskIfUserWantsToPlayCircle()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("DO YOU WANT TO PLAY WITH CIRCLE?  (y/n)");

        bool repeatSwitch = true;

        while (repeatSwitch)
        {
            switch (Console.ReadKey(true).KeyChar)
            {
                case 'y' : 

                repeatSwitch = false; circle = true;
                break;

                case 'n' :
                repeatSwitch = false; circle = false;
                break;

                default : repeatSwitch = true;
                break;
            }
        }
    }



    public static void DrawingMarker()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        string playerMarker = "██";


        //Places the marker on the "default" position
        Console.SetCursorPosition( (int) PosX.Middle, (int) PosY.Middle );
        Console.Write(playerMarker);

        MarkerMovement();
        

    }


    //Places the marker on the screen
    public static void DrawMarker(int posX, int posY)
    {
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.SetCursorPosition( posX, posY );
         Console.Write("██"); 
    }


    //Erases the marker from the screen
    public static void EraseMarker()
    {
         Console.ForegroundColor = ConsoleColor.Black;
         Console.SetCursorPosition( Console.CursorLeft - 2, Console.CursorTop );
         Console.Write("██"); 
    }



    static void MarkerMovement()
    {
      while (1 > 0)
      {

        (int Left, int Top) currentPos = Console.GetCursorPosition();
        var readPlayerInput = Console.ReadKey(true).Key;


		  //POS 1
		  if (currentPos == posOne && readPlayerInput == ConsoleKey.D)
		  { 
		      EraseMarker();
		      DrawMarker( (int)PosX.Middle, (int)PosY.Top );
		  }

		  else if (currentPos == posOne && readPlayerInput == ConsoleKey.S)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Left, (int)PosY.Middle );
		  }

		  else if (currentPos == posOne && readPlayerInput == ConsoleKey.Enter)
		  {


             //Checks if the AI already played that position
             if ( ( !posOnePlayed ) && (!AIposOnePlayed) )
		     {

		       if ( circle )
		       { DrawCircle(); }

		       else
		       { DrawX(); }

		       posOnePlayed = true;

		       //IF "AttackAI()" FINDS NO ATTACK PATTENRS, THE "DefenseAI()" LOOK FOR DEFENSE ONES
		       if ( ArtificialDumbness.AttackAI() == false )
		       { ArtificialDumbness.DefenseAI(); }

		     }

             //If that position has been taken by the AI, it just beeps the console and resets to the "default" position
		     else
		     { ResetMarker(); }
	 
		    break;
		  }






		  //POS 2
		  else if (currentPos == posTwo && readPlayerInput == ConsoleKey.D)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Right, (int)PosY.Top );
		  }
		  else if (currentPos == posTwo && readPlayerInput == ConsoleKey.S)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Middle, (int)PosY.Middle );
		  }
		  else if (currentPos == posTwo && readPlayerInput == ConsoleKey.A)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Left, (int)PosY.Top );
		  }

		  else if (currentPos == posTwo && readPlayerInput == ConsoleKey.Enter)
		  {

		     if ( ( !posTwoPlayed ) && ( !AIposTwoPlayed ) )
		     {

		       if ( circle )
		       { DrawCircle(); }

		       else
		       { DrawX(); }

		       posTwoPlayed = true;

		       if ( ArtificialDumbness.AttackAI() == false )
		       { ArtificialDumbness.DefenseAI(); }
 
		     }

		     else
		     { ResetMarker(); }

		    break;
		  }





		  //POS 3
		  else if (currentPos == posThree && readPlayerInput == ConsoleKey.A)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Middle, (int)PosY.Top );
		  }
		  else if (currentPos == posThree && readPlayerInput == ConsoleKey.S)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Right, (int)PosY.Middle );
		  }
		  
		  else if (currentPos == posThree && readPlayerInput == ConsoleKey.Enter)
		  {

			 if ( ( !posThreePlayed ) && ( !AIposThreePlayed ) )
			 {

		       if ( circle )
		       { DrawCircle(); }

		       else
		       { DrawX(); }

		       posThreePlayed = true;

		       if ( ArtificialDumbness.AttackAI() == false )
		       { ArtificialDumbness.DefenseAI(); }

			 }
			 
			 else
			 { ResetMarker(); }


		    break;
		  }




		  
		  //POS 4
		  else if (currentPos == posFour && readPlayerInput == ConsoleKey.D)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Middle, (int)PosY.Middle );
		  }
		  else if (currentPos == posFour && readPlayerInput == ConsoleKey.W)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Left, (int)PosY.Top );
		  }
		  else if (currentPos == posFour && readPlayerInput == ConsoleKey.S)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Left, (int)PosY.Bottom );
		  }
		  
		  else if (currentPos == posFour && readPlayerInput == ConsoleKey.Enter)
		  {

			 if ( ( !posFourPlayed ) && ( !AIposFourPlayed ) )
			 {

		       if ( circle )
		       { DrawCircle(); }

		       else
		       { DrawX(); }

		       posFourPlayed = true;

		       if ( ArtificialDumbness.AttackAI() == false )
		       { ArtificialDumbness.DefenseAI(); }

			 }

			 else
			 { ResetMarker(); }


		    break;
		  }





		  //POS 5
		  else if (currentPos == posFive && readPlayerInput == ConsoleKey.D)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Right, (int)PosY.Middle );
		  }
		  else if (currentPos == posFive && readPlayerInput == ConsoleKey.A)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Left, (int)PosY.Middle );
		  }
		  else if (currentPos == posFive && readPlayerInput == ConsoleKey.S)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Middle, (int) PosY.Bottom );
		  }
		  else if (currentPos == posFive && readPlayerInput == ConsoleKey.W)
		  {
		      EraseMarker();
		      DrawMarker( (int)PosX.Middle, (int)PosY.Top );
		  }

		  else if (currentPos == posFive && readPlayerInput == ConsoleKey.Enter)
		  {

             if ( ( !posFivePlayed ) && ( !AIposFivePlayed ) )
			 {
  
		       if ( circle )
		       { DrawCircle(); }

		       else
		       { DrawX(); }

		       posFivePlayed = true;

		       if ( ArtificialDumbness.AttackAI() == false )
		       { ArtificialDumbness.DefenseAI(); }

			 }

			 else
			 { ResetMarker(); }

		    break;
		  }





		  //POS 6
		  else if (currentPos == posSix && readPlayerInput == ConsoleKey.A)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Middle, (int)PosY.Middle );
		  }
		  else if (currentPos == posSix && readPlayerInput == ConsoleKey.S)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Right, (int)PosY.Bottom );
		  }
		  else if (currentPos == posSix && readPlayerInput == ConsoleKey.W)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Right, (int)PosY.Top );
		  }

		  else if (currentPos == posSix && readPlayerInput == ConsoleKey.Enter)
		  {

             if ( ( !posSixPlayed ) && ( !AIposSixPlayed ) )
			 {

		       if ( circle )
		       { DrawCircle(); }

		       else
		       { DrawX(); }

		       posSixPlayed = true;

		       if ( ArtificialDumbness.AttackAI() == false )
		       { ArtificialDumbness.DefenseAI(); }

			 }

			 else
			 { ResetMarker(); }

		    break;
		  }





		  //POS 7
		  else if (currentPos == posSeven && readPlayerInput == ConsoleKey.D)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Middle, (int)PosY.Bottom );
		  }
		  else if (currentPos == posSeven && readPlayerInput == ConsoleKey.W)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Left, (int)PosY.Middle );
		  }

		  else if (currentPos == posSeven && readPlayerInput == ConsoleKey.Enter)
		  {

			 if ( ( !posSevenPlayed ) && ( !AIposSevenPlayed ) )
			 {

		       if ( circle )
		       { DrawCircle(); }

		       else
		       { DrawX(); }
	 
		       posSevenPlayed = true;

		       if ( ArtificialDumbness.AttackAI() == false )
		       { ArtificialDumbness.DefenseAI(); }

			 }

			 else
			 { ResetMarker(); }


		    break;
		  }






		  //POS 8
		  else if (currentPos == posEight && readPlayerInput == ConsoleKey.D)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Right, (int)PosY.Bottom );
		  }
		  else if (currentPos == posEight && readPlayerInput == ConsoleKey.A)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Left, (int)PosY.Bottom );
		  }
		  else if (currentPos == posEight && readPlayerInput == ConsoleKey.W)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Middle, (int)PosY.Middle );
		  }

		  else if (currentPos == posEight && readPlayerInput == ConsoleKey.Enter)
		  {

             if ( ( !posEightPlayed ) && ( !AIposEightPlayed ) )
			 {

		       if ( circle )
		       { DrawCircle(); }

		       else
		       { DrawX(); }

		       posEightPlayed = true;

		       if ( ArtificialDumbness.AttackAI() == false )
		       { ArtificialDumbness.DefenseAI(); }

			 }

			 else
			 { ResetMarker(); }


		    break;
		  }





		  //POS 9
		  else if (currentPos == posNine && readPlayerInput == ConsoleKey.A)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Middle, (int)PosY.Bottom );
		  }
		  else if (currentPos == posNine && readPlayerInput == ConsoleKey.W)
		  {
		     EraseMarker();
		     DrawMarker( (int)PosX.Right, (int)PosY.Middle );
		  }

		  else if (currentPos == posNine && readPlayerInput == ConsoleKey.Enter)
		  {

             if ( ( !posNinePlayed ) && ( !AIposNinePlayed ) )
			 {

		       if ( circle )
		       { DrawCircle(); }

		       else
		       { DrawX(); }

		       posNinePlayed = true;

		       if ( ArtificialDumbness.AttackAI() == false )
		       { ArtificialDumbness.DefenseAI(); }

			 }

			 else
			 { ResetMarker(); }


		    break;
		  }

		 
	      }


		//If the match is over, it breaks the loop and the program ends
		//Else, it loops through the "MarkerMovement()" method again

		if ( CheckIfMatchIsOver() ) 
		{ Console.ReadKey(true); Console.Clear(); Console.WriteLine("Match is over"); } 

                else 
                { 
                  Console.SetCursorPosition( (int)PosX.Middle, (int)PosY.Middle ); 
                  Console.Write("██"); 
                  MarkerMovement(); 
                }

   }
}
