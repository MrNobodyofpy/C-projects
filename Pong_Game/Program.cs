using System;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            const int fieldLength = 50; 
            const int fieldWidth = 15;
            const char filedTile = '#';
            string line = string.Concat(Enumerable.Repeat(filedTile, fieldLength));

            while(true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(line);

                Console.SetCursorPosition(0, fieldWidth);
                Console.WriteLine(line);
                const int racketLength = fieldWidth / 4;
                const char racketTile = '|';

                int leftRacketHeight = 0;
                int rightRacketHeight = 0;

                for(int i = 0; i < racketLength; i++)
            {
                Console.SetCursorPosition(0, i + 1 + leftRacketHeight);
                Console.WriteLine(racketTile);
                Console.SetCursorPosition(fieldLength - 1, i + 1 + rightRacketHeight);
                Console.WriteLine(racketTile);
            }
            }

    }
}
}