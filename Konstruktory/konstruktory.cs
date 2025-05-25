using System;

public class Samochod
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Rocznik { get; set; }

    // Konstruktor domyślny (bez parametrów)
    public Samochod()
    {
        Marka = "Nieznana";
        Model = "Nieznany";
        Rocznik = 2000;
        Console.WriteLine("Wywołano konstruktor domyślny.");
    }

    // Konstruktor parametrowy
    public Samochod(string marka, string model, int rocznik)
    {
        Marka = marka;
        Model = model;
        Rocznik = rocznik;
        Console.WriteLine("Wywołano konstruktor parametrowy.");
    }

    // Konstruktor kopiujący (kopiuje dane z innego obiektu)
    public Samochod(Samochod innySamochod)
    {
        Marka = innySamochod.Marka;
        Model = innySamochod.Model;
        Rocznik = innySamochod.Rocznik;
        Console.WriteLine("Wywołano konstruktor kopiujący.");
    }

    public void WyswietlInfo()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, Rocznik: {Rocznik}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Użycie konstruktora domyślnego
        Samochod auto1 = new Samochod();
        auto1.WyswietlInfo();

        // Użycie konstruktora parametrowego
        Samochod auto2 = new Samochod("Toyota", "Corolla", 2022);
        auto2.WyswietlInfo();

        // Użycie konstruktora kopiującego
        Samochod auto3 = new Samochod(auto2);
        auto3.WyswietlInfo();
    }
}
