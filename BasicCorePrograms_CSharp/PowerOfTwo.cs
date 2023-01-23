
namespace BasicCorePrograms_CSharp
{
	public class PowerOfTwo
	{
		public static void PowerOfTwoTable()
		{
			Console.WriteLine("Enter the Value of Power for 2 is ");
			int PowerValue = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= PowerValue; i++)
			{
				double value = Math.Pow(2, i);
				Console.WriteLine("the value is 2^{0} : {1} ",i, value);
			}
		}
	}
}

