namespace CodewDan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input your string: ");
            string input = Console.ReadLine().ToLower();
            int[] arrayChars = new int[26];
            foreach (var letter in input)
            {
                if (letter >= 'a' && letter <= 'z')
                    arrayChars[(letter - 'a')]++;
            }
            Console.Write("Doubled up letters: ");
            for (int i = 0; i < 26; i++)
            {
                if (arrayChars[i] > 1)
                    Console.Write((char)(i+'a') + " ");
            }
        }
    }
}