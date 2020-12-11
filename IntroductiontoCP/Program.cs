using System;

namespace IntroductiontoCP
{
    class MainClass
    {
        public static void Main()
        {

             Console.WriteLine("Hello, world! :)");

             int x = 5;
             int y = 1;


             Console.WriteLine(x / y);

                double usd = 3.80;
                double zty = 100;


                    Console.Write ($"The amount is: {usd * zty}");


                double usd;
                double zty;

                    Console.WriteLine("Enter the USD price: ");
                    usd = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the Zloty ammount to convert: ");
                    zty = double.Parse(Console.ReadLine());

                    Console.Write($"The conversion ammount is: {usd * zty}"); 


                int a; 
                int b;
                int c;
                int x;

                Console.Write("Enter the value for a: ");
                  a = int.Parse(Console.ReadLine());
                Console.Write("Enter the valuefor b: ");
                  b = int.Parse(Console.ReadLine());
                Console.Write("Enter the value for c: ");
                  c = int.Parse(Console.ReadLine());
                Console.Write("Enter the vaue for x: ");
                  x = int.Parse(Console.ReadLine());


                Console.Write($"y={a * (x * x) + (b * x) + c }"); 

             int number;

             Console.Write("Enter a number: ");
             number = int.Parse(Console.ReadLine());

             Console.Write(2 * number); 

             Console.WriteLine("Please Write the size of the rectangle:");
             Console.WriteLine("x= ");
             Console.WriteLine("y= ");

             int x = int.Parse(Console.ReadLine());

             int y = int.Parse(Console.ReadLine());


             Console.WriteLine("Your rectangle is of size: {x} and {y}");

             for (int j = 0; j < y; j++)
             {
                 for (int i = 0; i < x; i++)
                 {
                     Console.Write('*');
                 }
                 Console.WriteLine();
             }


            Console.WriteLine("Write your birthday: ");
            int bday = int.Parse(Console.ReadLine());

            Console.Write($"Andre's birthday is december {bday}th.");

          
        }
    }
}
