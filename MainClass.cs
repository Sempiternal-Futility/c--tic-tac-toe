using System;

// TODO: 
// Fix DefenseAI ( i did some changes to it, however some further debugging is necessary to assure that is workign as in intended :)  )
// Fix bug that sometimes the AI will play twice in the same turn
// Fix "DrawRandomPosition()" not playing/stop working out of the blue
// Write a multiplayer feature

class MainClass
{

    static void Main()
    {
         Console.Clear();
         Console.CursorVisible = false;

	 //THIS METHOD LETS THE USER CHOOSE IF HE WANTS TO PLAY AS CIRCLE OR X
	 ExtraMethods.ChooseYourCharacter();

         ExtraMethods.DrawingBoard();

	 //THIS "MARKER" IS THE LITTLE CYAN SQUARE
         DrawingPlayer.MarkerMovement();
    }
}
