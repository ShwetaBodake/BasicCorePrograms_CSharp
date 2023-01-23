using System;
namespace BasicCorePrograms_CSharp
{
	public class QuotientAndReminder
	{
		public static void QuotientAndReminderDisplay()
		{
			Console.WriteLine("Enter the Dividand ");
			int Dividand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor ");
            int Divisor = Convert.ToInt32(Console.ReadLine());

			int Quotient = Dividand / Divisor;
			int Reminder = Dividand % Divisor;
			Console.WriteLine("The quotient is {0} and reminder is {1} ", Quotient, Reminder);
        }
	}
}

