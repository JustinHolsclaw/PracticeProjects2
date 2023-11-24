using System;
using System.Collections.Generic;

namespace practiceProjects
{
    class Program
    {
        public static int FindLargestNumber(List<int> numbers){
            int greatestNumber = 0;
            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] > greatestNumber)
                {
                    greatestNumber = numbers[i];
                }
            }
            return greatestNumber;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {10, 5, 8, 22, 3, 15, 9};
            int LargestNumber = FindLargestNumber(numbers);
            Console.WriteLine(LargestNumber);
        }
    }
}
