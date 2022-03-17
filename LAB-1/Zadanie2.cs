using System.Collections;

namespace ConsoleApp1;

public static class Zadanie2
{
    public static void UruchomZadanie2()
    {
        var userNumbers = new ArrayList();
        var uniqueElements = 0;
        while (true)
        {
            Console.Write("Wprowadź liczbę (lub n by zakończyć): ");
            String userInput = "";
            userInput = Console.ReadLine()!;
            if (userInput is "n")
            {
                break;
            }
            else
            {
                if (!userNumbers.Contains(Convert.ToInt32(userInput)))
                {
                    uniqueElements++;
                    Console.WriteLine("Wprowadzono: " + uniqueElements + " unikalnych liczb");
                }
                userNumbers.Add(Convert.ToInt32(userInput));
            }

        }
    }
}