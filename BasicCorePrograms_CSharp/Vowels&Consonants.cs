using System;
namespace BasicCorePrograms_CSharp
{
	public class Vowels_Consonants
	{
		public static void VowelsandConsonants()
		{
			Console.WriteLine("Enter the Alphabet ");
			char Character = Convert.ToChar(Console.ReadLine());

            if (Character == 'a' || Character == 'e' || Character == 'i' || Character == 'o' || Character == 'u' ||
             Character == 'A' || Character == 'E' || Character == 'I' || Character == 'O' || Character == 'U'
             )
            {
                Console.WriteLine("Entered Character is Vowel");
            }
            else
            {
                Console.WriteLine("Entered Character is Consonant");
            }
        }
	}
}

