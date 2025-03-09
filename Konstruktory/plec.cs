namespace ConsoleApp5
{

    public enum Gender
    {
        Mężczyzna,
        Kobieta,
        inna
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender PersonGender { get; set; }
        public int Age
        {
            get
            {
                DateTime Today = DateTime.Today;
                int age = Today.Year - DateOfBirth.Year;

                if (DateOfBirth.Date > Today.AddYears(-age))
                {
                    --age;
                }

                return age;
            }
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PersonGender = gender;
        }

        public override string ToString()
        {
            return $"Osoba o imieniu: {FirstName} i nazwisku: {LastName} urodzona: {DateOfBirth:yyyy-MM-dd} ma {Age} lata i jest płci {PersonGender}";
        }

        public static Person inputInfo()
        {
            Console.Write("Podaj Imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Podaj Nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Podaj datę urodzenia(yyyy-MM-dd): ");
            DateTime dateOfBirth;
            while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
            {
                Console.WriteLine("Podaj poprawną datę urodzienia(yyyy-MM-dd): ");
            }

            Console.Write("Podaj płeć (1 - Mężczyzna, 2 - Kobieta, 3 - inna): ");
            int genderChoice;

            while (!int.TryParse(Console.ReadLine(), out genderChoice) || genderChoice < 1 || genderChoice > 3)
            {
                Console.Write("Niepoprawny wybór. Wybierz ponownie (1 - Mężczyzna, 2 - Kobieta, 3 - inna): ");
            }

            Gender gender = (Gender)(genderChoice - 1);

            return new Person(firstName, lastName, dateOfBirth, gender);
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = Person.inputInfo();
            Console.WriteLine(person1);
            Console.ReadKey();
        }
    }
}
