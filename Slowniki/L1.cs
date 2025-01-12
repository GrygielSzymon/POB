using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Slowniki1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, string> translations = new Dictionary<string, string>();

            while(true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        Console.Write("Podaj słowo w języku angielskim:");
                        string key = Console.ReadLine();
                        Console.Write("Podaj słowo w języku polskim:");
                        string value = Console.ReadLine();
                        if (translations.ContainsKey(key))
                        {
                            Console.WriteLine("To słowo już jest w tym słowniku.");
                        }
                        else
                        {
                            translations.Add(key, value);
                            Console.WriteLine("Pomyślnie dodano tłumaczenie.");
                        }
                        break;
                    case "2":
                        Console.Write("Podaj słowo do znalezienia: ");
                        string searchKey = Console.ReadLine();
                        if (translations.TryGetValue(searchKey, out string translation))
                        {
                            Console.WriteLine($"Tłumaczenie: {translation}");
                        }
                        else
                        {
                            Console.WriteLine("W tym słowniku nei ma takiego tłumaczenia.");
                        }
                        break;
                    case "3":
                        foreach (var item in translations)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                        break;
                    case "4":
                        Console.Write("Podaj tłumaczenie które chcesz usunąc: ");
                        string deleteKey = Console.ReadLine();
                        if(translations.Remove(deleteKey))
                        {
                            Console.WriteLine("Tłumaczenie zostało usunięte.");
                        }
                        else
                        {
                            Console.WriteLine("Nie ma takiego tłumaczenia");
                        }
                        break;
                    case "5":
                        Console.Write("Podaj tłumaczenie które chcesz zaktualizować: ");
                        string updateKey = Console.ReadLine();
                        if (translations.ContainsKey(updateKey))
                        {
                            Console.Write("Podaj nowe tłumaczenie: ");
                            string newValue = Console.ReadLine();
                            translations[updateKey] = newValue;
                            Console.WriteLine("Tłumaczenie zostało pomyślnie zaktualizowane.");
                        }
                        else
                        {
                            Console.WriteLine("Nie ma takiego tłumaczenia.");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Do zobaczenia.");
                        break;
                    default:
                        Console.WriteLine("Zła opcja.");
                        break;
                }
            }
           
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\n Wybierz opcję: ");
            Console.WriteLine("1. Dodaj nowe tłumaczenie");
            Console.WriteLine("2. Znajdź tłumaczenie");
            Console.WriteLine("3. Wyświetl wszystkie tłumaczenia");
            Console.WriteLine("4. Usuń tłumaczenie");
            Console.WriteLine("5. zaktualizuj tłumaczenie");
            Console.WriteLine("6. Wyjdź");
        }

    }
}
