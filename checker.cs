using System;

namespace escapeRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            String secretCode = requestSecretCode(null);
            while (secretCode != 2015.ToString())
            {
                Console.Clear();
                secretCode = requestSecretCode("Your secret code is not valid! Please try again! ");
            }
            Console.Clear();
            Console.WriteLine("Congratulation! Your secret code is valid!");
        }

        static String requestSecretCode(String message)
        {
            if (message != null)
            {
                Console.WriteLine(message);
            }
            Console.Write("Please provide the secret code: ");
            return Console.ReadLine();
        }
    }
}