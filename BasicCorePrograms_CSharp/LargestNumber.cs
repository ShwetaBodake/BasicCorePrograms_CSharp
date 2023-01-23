using System;
namespace BasicCorePrograms_CSharp
{
	public class LargestNumber
	{
		public static void LargestNumberDisplay()
		{
            //----------------Largest number among three numbers----------------------------//
            Console.WriteLine("Enter first number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("Number {0} is the largest number", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Number {0} is the largest number", b);
            }
            else
            {
                Console.WriteLine("Number {0} is the largest number", c);
            }
        }

    }
}

