using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {


            
            int total;
            total = int.Parse(Console.ReadLine());

            
            Console.WriteLine("What total out of 100 do you expect to get in ISM 4300?");


            if (total >= 98)
            {
                Console.WriteLine("A+");
            }
            else if (total>= 92&&total<=97)
            {
                Console.WriteLine("A");
            }
            else if (total>=90&&total<=91)
            {
                Console.WriteLine("A-");
            }
            else if (total>=88&&total<=89)
            {
                Console.WriteLine("B+");
            }
            else if (total>=82&&total<=87)
            {
                Console.WriteLine("B");
            }
            else if (total>=80&&total<=81)
            {
                Console.WriteLine("B-");
            }
            else if (total>=78&&total<=79)
            {
                Console.WriteLine("C+");
            }
            else if (total>=72&&total<=77)
            {
                Console.WriteLine("C");
            }
            else if (total>=70&&total<=71)
            {
                Console.WriteLine("C-");
            }
            else if (total>=68&&total<=69)
            {
                Console.WriteLine("D+");
            }
            else if (total>=62&&total<=67)
            {
                Console.WriteLine("D");
            }
            else if (total>=60&&total<=61)
            {
                Console.WriteLine("D-");
            }
            else if (total <=60)
            {
                Console.WriteLine("F");
            }

                
                
        }
    }
}
