
namespace BasicCorePrograms_CSharp
{
	public class SwapNumber
	{
	    public static void SwapNumberDisplay()
		{
			int temp = 0;

			Console.WriteLine("Enter the first number");
			int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int Second = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Numbers before swaping {0} {1}", first, Second);
			temp = first;
			first = Second;
			Second = temp;
            Console.WriteLine("Numbers After swaping {0} {1}", first, Second);
		}

	}
}

