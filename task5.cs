using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string words = Console.ReadLine();


            string corrected = Corrected(words);
            Console.WriteLine(corrected);

           Console.ReadLine();


           

        }


        public static string Corrected(string words)
        {
            words = words.Trim(); 
            string[] words2 = words.Split(' '); 

            for (int i = 0; i < words2.Length; i++)
            {
                if (words2[i].Length > 0)
                {
                    words2[i] = words2[i].ToUpper() + words2[i].ToLower();
                }
            }

            words = string.Join(" ", words2);

            return words;
        }
    }
}