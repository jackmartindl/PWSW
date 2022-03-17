namespace ConsoleApp1;

public static class Zadanie5
{
    private static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba <= 1) return false;
        if (liczba == 2) return true;
        if (liczba % 2 == 0) return false;

        var granica = (int)Math.Floor(Math.Sqrt(liczba));
          
        for (int i = 3; i <= granica; i += 2)
            if (liczba % i == 0)
                return false;
    
        return true;        
    }
    
    public static void Uruchom()
    {
        Console.Write("Wprowadź liczbę: ");
        var liczba = Console.Read();

        if (CzyLiczbaPierwsza(liczba))
        {
            Console.WriteLine("Wprowadzona liczba jest liczbą pierwszą!");
        }
        else
        {
            Console.WriteLine("Wprowadzona liczba nie jest liczbą pierwszą!");
        }
    }
}