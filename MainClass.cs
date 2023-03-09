using System;

// TODO: 
// Write a config.txt file, within it you will be able to set multiplayer to false or true, select or character to false or true, and have difference color schemes to choose from
// Write a "play again" feature
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
