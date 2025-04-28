using TaskApp.Models;

namespace TaskApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
            TaskApp.Models.Task task1 = new TaskApp.Models.Task("zadanie 1", "opis zadania", DateTime.Now.AddDays(5), true, Prioritylevel.Średni);
            task1.DueTime = DateTime.Now.AddDays(2);
            task1.IsCompleted = false;
            task1.DisplayInfo();

            //zadanie 2
            TaskApp.Models.Task task2 = new TaskApp.Models.Task("zadanie 2", "opis zadania", DateTime.Now.AddDays(5), true, Prioritylevel.Wysoki);
            task2.DisplayInfo();

            // Próba ustawienia daty w przeszłości
            try
            {
                task2.DueTime = DateTime.Now.AddDays(-5);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }

            // Poprawne przesunięcie daty o 5 dni do przodu
            task2.DueTime = task2.DueTime.AddDays(5);
            task2.DisplayInfo();

            try
            {
                task2.Priority = Prioritylevel.Niski;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }

            task2.DisplayInfo();

        }
    }
}
