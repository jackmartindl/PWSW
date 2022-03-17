namespace ConsoleApp1;

public static class Zadanie1
{
    public static void UruchomZadanie1()
    {
        var numberToGuess = new Random().Next(0, 100);
        var numberGuessed = false;
        while (!numberGuessed)
        {
            Console.Write("Wprowadź liczbę: ");
            var userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber < numberToGuess)
            {
                Console.WriteLine("Wprowadzona liczba jest mniejsza od prawidłowej!");
            }
            else if (userNumber > numberToGuess)
            {
                Console.WriteLine("Wprowadzona liczba jest większa od prawidłowej!");
            }
            else
            {
                Console.WriteLine("Liczba została odgadnięta!");
                numberGuessed = true;
            }
        }

    }
}