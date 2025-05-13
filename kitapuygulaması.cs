using System;
using System.Collections.Generic;

class Kitap
{
    public string Adi { get; set; }
    public int BasimYili { get; set; }
    public string YazarAdi { get; set; }
    public int Stok { get; set; }

    public Kitap(string adi, int basimYili, string yazarAdi, int stok)
    {
        Adi = adi;
        BasimYili = basimYili;
        YazarAdi = yazarAdi;
        Stok = stok;
    }
}

class Program
{
    static void Main()
    {
        List<Kitap> kitaplar = new List<Kitap>();

        
        Kitap kitap1 = new Kitap("Suç ve Ceza", 1866, "Fyodor Dostoyevski", 10);
        Kitap kitap2 = new Kitap("1984", 1949, "George Orwell", 5);
        Kitap kitap3 = new Kitap("Kürk Mantolu Madonna", 1943, "Sabahattin Ali", 7);

       
        kitaplar.Add(kitap1);
        kitaplar.Add(kitap2);
        kitaplar.Add(kitap3);

        
        foreach (Kitap kitap in kitaplar)
        {
            Console.WriteLine($"Adı: {kitap.Adi}, Basım Yılı: {kitap.BasimYili}, Yazar: {kitap.YazarAdi}, Stok: {kitap.Stok}");
        }
    }
}
