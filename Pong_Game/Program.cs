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
            }

    }
}
}