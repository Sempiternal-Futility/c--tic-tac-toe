using System;

// TODO: 
// Write winning, losing and tie conditions
// Fix DefenseAI ( i did some changes to it, however some further debugging is necessary to assure that is workign as in intended :)  )
// Fix bug that sometimes the AI will play twice in the same turn
// Make the process of choosing your character more intuivive, with the marker
// Fix "DrawRandomPosition()" not playing/stop working out of the blue
// Write a multiplayer feature

class MainClass : DrawingPlayer
{

    static void Main()
    {
         Console.Clear();
         Console.CursorVisible = true;

         AskIfUserWantsToPlayCircle();

         ExtraMethods.DrawingBoard();

         DrawingMarker();
    }
}
