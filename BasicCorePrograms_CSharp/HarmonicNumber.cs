using System;
namespace BasicCorePrograms_CSharp
{
	public class HarmonicNumber
	{
		public static void HarmonicNumberDisplay()
		{
            double sum = 0.0;
            Console.WriteLine("Enter the Number ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (double i = 1; i <= number; i++)
            {
                Console.Write(" 1/{0}", i);
                sum = sum + (1 / i);
                Console.WriteLine();
            }
            Console.WriteLine("Harmonic Number is {0}",sum);


        }
	}
}

