
namespace Sprawdzian
{
    public enum AnimalType
    {
        Ssaki,
        Ptaki,
        Gady,
        Płazy,
        Ryby,
        Owady
    }
    public class Animal
    {
        public string Name { get; set; }
        public AnimalType Spieces { get; set; }
        public string Type { get; set; }
        public DateTime BirthDate { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public Animal(string name, AnimalType spieces)
        {
            Name = name;
            Spieces = spieces;
        }

        public Animal(string name, AnimalType spieces, string type)
        {
            Name = name;
            Spieces = spieces;
            Type = type;
        }

        public Animal(string name, AnimalType spieces, string type, DateTime birthDate)
        {
            Name = name;
            Spieces = spieces;
            Type = type;
            BirthDate = birthDate;
        }

        public static Animal InputAnimalData()
        {
            Console.Write("Podaj nazwę zwierzęcia: ");
            string name = Console.ReadLine();

            Console.WriteLine("Wybierz typ zwierzęcia (0: Ssaki, 1: Ptaki, 2: Gady, 3: Płazy, 4: Ryby, 5: Owady): ");
            int animalTypeInput;
            while (!int.TryParse(Console.ReadLine(), out animalTypeInput) || animalTypeInput < 0 || animalTypeInput > 5)
            {
                Console.WriteLine("Zły wybór");
            }

            AnimalType type = (AnimalType)animalTypeInput;

            Console.Write("Podaj typ zwierzęcia: ");
            string animalType = Console.ReadLine();

            Console.Write("Podaj datę urodzenia zwierzęcia (yyyy-mm-dd): ");
            DateTime birthDate;
            while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                Console.WriteLine("Zły format daty. Spróbuj ponownie.");
            }

            return new Animal(name, type, animalType, birthDate);
        }

        public override string ToString()
        {
            return $"Nazwa: {Name}, Typ: {Type}, Gatunek: {Spieces}, Data urodzenia: {BirthDate:yyyy-MM-dd}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = Animal.InputAnimalData();
            Console.WriteLine(animal1);
            Console.ReadKey();
        }
    }
}
