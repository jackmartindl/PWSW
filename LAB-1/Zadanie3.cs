namespace ConsoleApp1;

public static class Zadanie3
{
    public static void UruchomZadanie3()
    {
        Console.Write("Wprowadź liczbę binarną: ");
        var userInput = Console.ReadLine()!;

        var numberOfHoles = 0;
        var startOfHoleDetected = false;
        for (var i = 0; i < userInput.Length; i++)
        {
            if (userInput[i].Equals('1') && !startOfHoleDetected)
            {
                startOfHoleDetected = true;
            } else if (startOfHoleDetected && userInput[i].Equals('1'))
            {
                numberOfHoles++;
            }
        }

        Console.WriteLine("Zliczono: " + numberOfHoles + " dziur binarnych.");
    }
}