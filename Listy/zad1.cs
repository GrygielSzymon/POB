using System;
using System.Collections.Generic;
using System.Linq;

namespace POB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            bool exit = false;

            while (!exit)
            {
                displayMenu();

                Console.Write("Wybierz punkt menu: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addElementsManually(list);
                        break;
                    case 2:
                        addElementsRandomly(list);
                        break;
                    case 3:
                        deleteElements(list);
                        break;
                    case 4:
                        showList(list);
                        break;
                    case 5:
                        sort(list);
                        break;
                    case 6:
                        sortdesc(list);
                        break;
                    case 7:
                        clearList(list);
                        break;
                    case 8:
                        findElements(list);
                        break;
                    case 9:
                        stats(list);
                        break;
                    case 10:
                        removeDuplicates(list);
                        break;
                    case 11:
                        exit = true;
                        break;

                    default:
                        break;
                }

            }
        }
        static void displayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Dodaj element do listy");
            Console.WriteLine("2. Dodaj losowe elementy do listy");
            Console.WriteLine("3. Usuń element z listy");
            Console.WriteLine("4. Wyświetl listę");
            Console.WriteLine("5. Posortuj rosnąco");
            Console.WriteLine("6. Posortuj malejąco");
            Console.WriteLine("7. Wyczyść listę");
            Console.WriteLine("8. Wyszukiwanie w liscie");
            Console.WriteLine("9. Statystyki");
            Console.WriteLine("10. Usuń duplikaty z listy");
            Console.WriteLine("11. Wyjdź");
        }

        static void addElementsManually(List<int> list)
        {
            Console.Write("Podaj ilość elementów do dodania: ");
            int amountOfNumbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < amountOfNumbers; i++)
            {
                Console.WriteLine($"Podaj element: {i + 1}");
                int listAdd = int.Parse(Console.ReadLine());
                list.Add(listAdd);
            }
        }

        static void addElementsRandomly(List<int> list)
        {
            Console.Write("Podaj ilość elementów do dodania randomowo: ");
            int listAdd = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i <= listAdd; i++)
            {
                list.Add(random.Next(1, 101));
            }
            Console.WriteLine($"Dodano {listAdd} elementów do listy");
        }

        static void deleteElements(List<int> list)
        {
            Console.Write("Podaj numer do udunięcia: ");
            int number = int.Parse(Console.ReadLine());
            if (list.Contains(number))
            {
                list.Remove(number);
                Console.WriteLine($"Usunięto numer: {number} z listy");
            }
            else
            {
                Console.WriteLine("Nie ma takiego numeru w liście");
            }
        }

        static void showList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void sort(List<int> list)
        {
            list.Sort();
            Console.WriteLine("Lista została posortowana rosnąco");
        }

        static void sortdesc(List<int> list)
        {
            list.Sort();
            list.Reverse();
            Console.WriteLine("Lista została posortowana malejąco");
        }

        static void clearList(List<int> list)
        {
            list.Clear();
            Console.WriteLine("Lista została wyczyszczona.");
        }

        static void findElements(List<int> list)
        {
            Console.Write("Podaj Element do znalezienia: ");
            int findElement = int.Parse(Console.ReadLine());
            if (findElement > 0)
            {
                if (list.Contains(findElement))
                {
                    Console.WriteLine(string.Join(", ", list.FindAll(x => x == findElement)));
                }
                else
                {
                    Console.WriteLine("Nie ma takiego numeru w liście");
                }
            }
            else
            {
                Console.WriteLine("Podaj Dodatni numer.");
            }
        }

        static void stats(List<int> list)
        {
            int count = list.Count;
            int min = list.Min();
            int max = list.Max();
            double avg = list.Average();
            int sum = list.Sum();
            Console.WriteLine("Statystyki: ");
            Console.WriteLine($"Ilośc elementów: {count}");
            Console.WriteLine($"Najmniejsza wartośc: {min}");
            Console.WriteLine($"Największa wartość: {max}");
            Console.WriteLine($"Średnia wartość: {avg}");
            Console.WriteLine($"Suma elementów: {sum}");


        }

        static void removeDuplicates(List<int> list)
        {
            List<int> uniqueList = new List<int>(new HashSet<int>(list));
            list.Clear();
            list.AddRange(uniqueList);
            Console.WriteLine("Duplikaty zostały usunięte z listy.");
        }
    }
}
