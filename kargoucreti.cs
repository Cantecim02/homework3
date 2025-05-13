using System;

class Program
{
    static void Main()
    {
        Console.Write("Kargonun ağırlığını (kg) gir: ");
        double kg = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kargonun mesafesini (km) gir: ");
        double km = Convert.ToDouble(Console.ReadLine());

        double ucret = KargoUcretiHesapla(kg, km);

        Console.WriteLine("Toplam kargo ücreti: " + ucret + "₺");
    }

    static double KargoUcretiHesapla(double kg, double km)
    {
        double baslangicUcreti = 100;
        double kgUcreti = kg * 5;
        double kmUcreti = km * 1;

        double toplamUcret = baslangicUcreti + kgUcreti + kmUcreti;

        return toplamUcret;
    }
}
