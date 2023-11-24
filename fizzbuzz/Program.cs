using System;
using System.Collections.Generic;

namespace practiceProjects
{
    class Program
    {
        public static void FizzBuzz(int limit){
            
           for(int i = 1; i < limit+1; i++)
           {
            bool Fizz = false;
            bool Buzz = false;
            if(i%3 == 0 )
            {
                Fizz = true;
            }
            if(i%5 == 0)
            {
                Buzz = true;
            }

            switch((Fizz, Buzz))
            {
                case (true, true):
                    Console.WriteLine("FizzBuzz");
                    break;
                case (true, false):
                    Console.WriteLine("Fizz");
                    break;
                case (false, true):
                    Console.WriteLine("Buzz");
                    break;
                case (false, false):
                    Console.WriteLine(i);
                    break;
            }
           }
        }
        static void Main(string[] args)
        {
            FizzBuzz(60);
        }
    }
}
