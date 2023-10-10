using System;
namespace CodingTankME
{
    public class Assets
    {
        public static string horizontalLine()
        //creates a horizontal line to divide terminal
        {
            int lineWidth = Console.WindowWidth;
            char lineChar = '_';
            return new string(lineChar, lineWidth);
        }
    }
}

