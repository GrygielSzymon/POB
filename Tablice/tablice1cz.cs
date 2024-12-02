namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pobranie rozmiaru tablicy od usera
            Console.Write("Podaj rozmiar tablicy: ");
            int size = int.Parse(Console.ReadLine());

            //wywołanie funkcji do tworzenia tablicy
            int[] array = CreateArray(size);

            //pytanie urzykownik czy chce wyświetlić tablicę?
            Console.WriteLine("Czy chcesz wyświetlić zawartość tablicy (tak/nie");
            string response = Console.ReadLine().ToLower();

            if (response == "tak")
            {
                DisplayArray(array);
            }
            else
            {
                Console.WriteLine("Zawartosć tablicy nie została wyswietlona");
            }
        }
        //Funkcja statyczna do tworzenia tablicy
        static int[] CreateArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1,101);
            }
            return array;
        }

        //Funkcja statyczna do wyświetlania tablicy
        static void DisplayArray(int[] array)
        {
            foreach(int element in array)
            {
                Console.WriteLine(element + " ");
            }
            Console.WriteLine();
        }
    }
}
