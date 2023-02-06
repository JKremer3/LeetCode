using System;
using System.Collections;

namespace Undo
{
    class Program
    {
        static void Main()
        {
            /*
             * Edge Cases: 
             * Popping with nothing on stack
             * Pushing past [4]
             * popping > 5
             *
             * Normal Cases:
             * pushing into basic array
             * popping after item on stack
            */

            var undo = new UnDo();

            try
            {
                undo.Pop(); // Should throw exception
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            
            for (int i = 0; i < 6; i++)
            {
                undo.Push('A');
            }

            try
            {
                for (int i = 0; i < 6; i++)
                {
                    var c = undo.Pop();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
            
            
            undo.Push('A');
            undo.Push('B');
            undo.Push('C');
            undo.Push('D');
            undo.Push('E');
            undo.Push('F');
            undo.Push('G');
            undo.Push('H');
            undo.Push('I');
            Console.WriteLine(undo.Pop());
            Console.WriteLine(undo.Pop());
            Console.WriteLine(undo.Pop());
            Console.WriteLine(undo.Pop());
            Console.WriteLine(undo.Pop());
        }
    }

    class UnDo
    {
        private char[] arr = new char[5];
        private int place = 0;
        private int currViable = 0;
        
        public void Push(char c)
        {
            arr[place] = c;
            if (place < 4)
            {
                place++;
            }
            else
            {
                place = 0;
            }

            if (currViable < 5)
            {
                currViable++;
            }
            
        }

        public char Pop()
        {
            // start at current place, go backwards
            // if at 0 check for value at [4], if there is, set place to 4
            //          place
            //           v
            // | A | B |  |  |  |
            if (currViable == 0)
            {
                throw new Exception("No Values on Stack");
            }
            
            if (place == 0)
            {
                place = 4;
            }
            else
            {
                place--;
            }
            
            var retChar = arr[place];
            currViable--;
            
            return retChar;

        }
    }
}