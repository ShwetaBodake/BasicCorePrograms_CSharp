using System;
namespace BasicCorePrograms_CSharp
{
	public class LeapYear
	{
		public static void FindLeapYear()
		{
			Console.WriteLine("Enter the Year :- ");
			int Year = Convert.ToInt32(Console.ReadLine());
			if(Year>999 && Year<=9999)
			{
				if(Year %4==0)
				{
					Console.WriteLine("Given Year {0} is Leap Year", Year);
				}
				else
				{
					Console.WriteLine("Given Year {0} is not a Leap Year",Year);
				}
			}
			else
			{
				Console.WriteLine("Year should be in four digit. ");
			}
		}
	}
}

