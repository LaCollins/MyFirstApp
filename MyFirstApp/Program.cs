using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter your name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine($"Hello {userEntry}!");

            if (userEntry == "Laura")
            {
                Console.WriteLine("You are awesome!");
            }
            else
            {
                Console.WriteLine("You are awesome, but not as awesome as Laura.");
            };

            var i = 0;
            while (i < 10)
            {
                Console.WriteLine($"Current value of i is {i++}...");
            }

            for (var j = 0; j < 10; j++)
            {
                Console.WriteLine($"Current value of j is {j}...");
            }

            foreach (var currentCharacter in userEntry)
            {
                if (currentCharacter == 'n' || currentCharacter == 'N')
                {
                    continue;
                }

                Console.WriteLine($"The current character is {currentCharacter}.");
            }

            switch (userEntry)
            {
                case "Laura":
                    Console.WriteLine("It's Laura");
                    break;
                default:
                    Console.WriteLine("It's not Laura");
                    break;
            }

            //var isLaura = userEntry == "Laura" ? true : false;
            var isLaura = userEntry == "Laura";

            //    try
            //    {
            //        var y = 0;
            //        var x = 1 / y;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //        throw;
            //    }
        }
    }
}

