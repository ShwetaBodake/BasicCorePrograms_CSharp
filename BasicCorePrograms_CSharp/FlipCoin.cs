using System;
namespace BasicCorePrograms_CSharp
{
	public class FlipCoin
	{
		public static void FlipCoinPercentage()
		{
            //  ------------------Flip Coin Percentage----------------//

            int headcount = 0;
            int tailcount = 0;
            Console.WriteLine("Enter the number of time Flip the coin");
            int number = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 1; i <= number; i++)
            {
                double result = random.NextDouble();
                if (result < 0.5)
                {
                    headcount++;
                }
                else
                {
                    tailcount++;
                }
            }
            Console.WriteLine("After fliping coin HeadPercentage is" + (headcount * 100) / number);
            Console.WriteLine("After fliping coin TailPercentage is" + (tailcount * 100) / number);
          
        }
    }
}

