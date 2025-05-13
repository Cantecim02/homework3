using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hangi işlemi yapmak istiyorsun? (+, -, *, /)");
        string islem = Console.ReadLine();

        Console.Write("1. sayıyı gir: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. sayıyı gir: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        double sonuc = 0;

        switch (islem)
        {
            case "+":
                sonuc = Topla(sayi1, sayi2);
                break;
            case "-":
                sonuc = Cikar(sayi1, sayi2);
                break;
            case "*":
                sonuc = Carp(sayi1, sayi2);
                break;
            case "/":
                if (sayi2 != 0)
                {
                    sonuc = Bol(sayi1, sayi2);
                }
                else
                {
                    Console.WriteLine("Sıfıra bölme hatası!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem seçildi.");
                return;
        }

        Console.WriteLine("Sonuç: " + sonuc);
    }

    static double Topla(double a, double b)
    {
        return a + b;
    }

    static double Cikar(double a, double b)
    {
        return a - b;
    }

    static double Carp(double a, double b)
    {
        return a * b;
    }

    static double Bol(double a, double b)
    {
        return a / b;
    }
}
