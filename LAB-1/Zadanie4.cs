using System.Collections;

namespace ConsoleApp1;

public static class Zadanie4
{
    private static string[] numbersA;
    private static string[] numbersB;
    
    private static void SumaZbiorow()
    {
        var sumaZbiorow = numbersA.Union(numbersB).ToList();

        Console.Write("Suma podanych zbiorów to: ");
        foreach (var liczba in sumaZbiorow)
        {
            Console.Write(liczba + ", ");
        }
    }

    private static void RoznicaZbiorow()
    {
        Console.Write("Podaj sposób różnicy zbiorów (A/B lub B/A): ");
        var sposobRoznicy = Console.ReadLine()!;

        var roznicaZbiorow = new List<string>();
        if (sposobRoznicy.Equals("A/B"))
        {
            roznicaZbiorow = numbersA.Except(numbersB).ToList();
        } else if (sposobRoznicy.Equals("B/A"))
        {
            roznicaZbiorow = numbersB.Except(numbersA).ToList();
        }
        
        Console.Write("Różnica podanych zbiorów to: ");
        foreach (var liczba in roznicaZbiorow)
        {
            Console.Write(liczba + ", ");
        }
    }

    private static void CzescWspolnaZbiorow()
    {
        var czescWspolnaZbiorow = numbersA.Intersect(numbersB).ToList();
        
        Console.Write("Część wspólna podanych zbiorów to: ");
        foreach (var liczba in czescWspolnaZbiorow)
        {
            Console.Write(liczba + ", ");
        }
    }

    private static void RoznicaSymetrycznaZbiorow()
    {
        var roznicaSymetrycznaZbiorow = numbersA.Except(numbersB).Concat(numbersB.Except(numbersA)).ToList();

        Console.Write("Różnica symetryczna podanych zbiorów to: ");
        foreach (var liczba in roznicaSymetrycznaZbiorow)
        {
            Console.Write(liczba + ", ");
        }
    }
    
    private static void WczytajZbiory()
    {
        Console.Write("Wprowadź elementy zbioru A po przecinku: ");
        var userNumbers = Console.ReadLine();
        if (userNumbers != null) numbersA = userNumbers.Split(", ");

        Console.Write("Wprowadź elementy zbioru B po przecinku: ");
        userNumbers = Console.ReadLine();
        if (userNumbers != null) numbersB = userNumbers.Split(", ");
    }
    public static void Uruchom()
    {
        WczytajZbiory();
        Console.Write("Wprowadź znak co chcesz zrobić z zbiorami (+, -, c.w., r.s.): ");
        var znak = Console.ReadLine();
        if (znak != null)
        {
            switch (znak)
            {
                case "+":
                    SumaZbiorow();
                    break;
                
                case "-":
                    RoznicaZbiorow();
                    break;
                
                case "c.w.":
                    CzescWspolnaZbiorow();
                    break;
                
                case "r.s.":
                    RoznicaSymetrycznaZbiorow();
                    break;
                
                default:
                    Console.WriteLine("Wprowadzono błędny znak!");
                    break;
            }
        }
    }
}