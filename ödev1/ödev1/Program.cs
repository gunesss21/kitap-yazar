using System;
using System.Collections.Generic;

public class Kitap
{
    public string Baslik { get; set; }
    public string ISBN { get; set; }

    public Kitap(string baslik, string isbn)
    {
        Baslik = baslik;
        ISBN = isbn;
    }

    public override string ToString()
    {
        return $"Başlık: {Baslik}, ISBN: {ISBN}";
    }
}

public class Yazar
{
    public string Ad { get; set; }
    public string Ulke { get; set; }
    public List<Kitap> Kitaplar { get; set; }

    public Yazar(string ad, string ulke)
    {
        Ad = ad;
        Ulke = ulke;
        Kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
    }

    public override string ToString()
    {
        string kitapListesi = string.Join("\n", Kitaplar);
        return $"Ad: {Ad}, Ülke: {Ulke}, Kitaplar:\n{kitapListesi}";
    }
}

class Program
{
    static void Main()
    {
        // Yazar ve kitap örneği oluşturma
        Yazar yazar = new Yazar("Orhan Pamuk", "Türkiye");

        Kitap kitap1 = new Kitap("Kırmızı Saçlı Kadın", "9789750842363");
        Kitap kitap2 = new Kitap("Masumiyet Müzesi", "9789750845647");

        yazar.KitapEkle(kitap1);
        yazar.KitapEkle(kitap2);

        Console.WriteLine(yazar);
    }
}