using System;
namespace BasicCorePrograms_CSharp
{
	public class EvenOddNumber
	{
		public static void EvenOddNumberDisplay()
		{
			Console.WriteLine("Enter the Number");
			int num = Convert.ToInt32(Console.ReadLine());

			if(num%2==0)
			{
				Console.WriteLine("Given number is Even");
			}
			else
			{
				Console.WriteLine("Given number is Odd");
			}
		}
	}
}

