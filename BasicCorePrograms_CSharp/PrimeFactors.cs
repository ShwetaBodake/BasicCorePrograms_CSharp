using System;
namespace BasicCorePrograms_CSharp
{
	public class PrimeFactors
	{
		public static void PrimeFactorsofNumber()
		{
			int count = 0;
			Console.WriteLine("Enter the number");
			int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("{0} number is prime number", number);
            }
            else
                Console.WriteLine("{0} number is not a prime number", number);



            //int factor = 1;
            //for(factor=1;factor<=number ;factor++)
            //{
            //	int isPrime = number % factor;

            //             if (isPrime == 0)
            //	{
            //		Console.WriteLine("It is a factor of given number {0} ", factor);
            //                 int temp = factor;
            //                 for (int i = 1; i <= temp; i++)
            //                 {
            //                     if (temp % i == 0)
            //                     {
            //                         count++;
            //                     }

            //                 }
            //                 if (count == 2)
            //                 {
            //                     Console.Write("Prime factors of number {0} ", temp);
            //                 }

            //             }
            //}





        }
    }
}

