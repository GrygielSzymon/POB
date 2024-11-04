using System;

namespace _2_string
{
	internal class Program
	{
		static void Main(string[] args, string formatname)
		{
			/*
			Console.WriteLine("Hello, World!");
			//interpolacja ciągów 
			string firstname = "Janusz";
			string lastname = "Nowak";
			string fullname = $"{firstname} {lastname}";
			Console.WriteLine(fullname);    //Janusz Nowak

			//literały dosłowne 
			string path = "C:\\Users\\Administrator\\source\\repos\\2_string\\2_string";
			Console.WriteLine(path);

			path = @"C:\Users\Administrator\source\repos\2_string\2_string";
			Console.WriteLine(path);

			string multiline = @"To jest 
wieloliniowy 
ciąg znaków";
			Console.WriteLine(multiline);

			//metody manipulacji ciągamia
			//replace
			string Text = "Programowanie obiektowe";
			string newText = Text.Replace("obiektowe", "strukturalne");
			Console.WriteLine(newText);

			newText = newText.Replace('e', 'E');
			Console.WriteLine(newText);

			//split
			string sentence = "Janek,Nowak,Programista";
			string[] words = sentence.Split(',');
			foreach (string word in words)
			{
				Console.WriteLine(word);
			}

			string sentence1 = "Janusz Nowak mieszka w Poznaniu";
			string[] words1 = sentence1.Split(' ');
			foreach (string word in words1)
			{
				Console.Write(word + '.');
			}
			Console.WriteLine();

			// split z wieloma opcjami
			string sentence2 = "Franek;Nowak,Poznań";
			char[] separators = { ';', ',' };
			string[] words2 = sentence2.Split(separators);
			foreach (string word in words2)
			{
				Console.WriteLine(word);
			}

			// split z opcjami StringSplitOptions
			string sentence3 = "Franek;;Nowak,Poznań";
			char[] separators3 = { ';', ',' };
			string[] words3 = sentence3.Split(separators3, StringSplitOptions.RemoveEmptyEntries);
			foreach (string word in words3)
			{
				Console.WriteLine(word);
			}

			//split z ograniczeniem liczby podciągów 
			string sentence4 = "Franio;Nowak;poznań; programista";
			char[] separators4 = { ';' };
			string[] words4 = sentence4.Split(separators4, 3);
			foreach (string word in words4)
			{
				Console.WriteLine(word);
			}



			//trim
			string text2 = "  Franciiiek";
			Console.WriteLine(text2.Length);
			Console.WriteLine(text2);
			text2 = text2.Trim();
			Console.WriteLine(text2.Length);
			Console.WriteLine(text2);

			string text3 = " Janusz  ";
			string trimmedstart = text3.TrimStart();
			string trimmedend = text3.TrimEnd();
			Console.WriteLine(text3.Length);
			Console.WriteLine(trimmedstart.Length);
			Console.WriteLine(trimmedend.Length);

			string trim = text3.Trim();
			Console.WriteLine(trim.Length);
			*/

			//Join
			string[] fruits = { "banan", "czereśnia", "arbuz" };
			string result = string.Join("	", fruits);
			Console.WriteLine(result);

			string[] numbers = { "jeden", "dwa", "trzy" };
			string result1 = string.Join(" - ", numbers);
			Console.WriteLine(result1);


			//substring
			string text5 = "Janusz Nowak";
			string substring = text5.Substring(7);  //Nowak
			substring = text5.Substring(7, 4);  //Nowa
			substring = text5.Substring(0, 6);  //Janusz
			substring = text5.Substring(text5.Length - 1);  //k
			substring = text5.Substring(text5.Length - 2);  //ak
			substring = text5.Substring(text5.Length - 2, 1);  //a
			substring = text5.Substring(text5.Length - 5);  //Nowak
			substring = text5.Substring(text5.Length - 5, 0);  //nic nie wyświetla (pusty napis)
			Console.WriteLine(substring);

			//ToUpper
			string text6 = "arbuz";
			string uppertext  = text6.ToUpper();
            Console.WriteLine(uppertext); //ARBUZ

			//ToLower
			string text7 = "Janusz";
			string lowertext  = text7.ToLower();
            Console.WriteLine(lowertext); //janusz

			//Contains
			string text8 = "Janusz Kowalski";
			bool containstext = text8.Contains("Janusz"); //True
			containstext = text8.Contains("janusz");//False
			bool containsTextIgnoreCase = text8.Contains("janusz", StringComparison.OrdinalIgnoreCase); //True
			Console.WriteLine(containstext); //True

			//IndexOff
			string text9 = "Anna Paweł Anna Tomasz Anna";
			int index = text9.IndexOf("Anna");	//0
			index = text9.IndexOf("Paweł"); //5
			index = text9.IndexOf("Anna", 6); //11
			index = text9.IndexOf("Anna", 6, StringComparison.OrdinalIgnoreCase); //11
			index = text9.IndexOf("Anna", 6, 8, StringComparison.OrdinalIgnoreCase); //-1
			index = text9.IndexOf("Anna", 6, 4, StringComparison.OrdinalIgnoreCase); //-1
			index = text9.IndexOf("Anna", 6, 9, StringComparison.OrdinalIgnoreCase); //11
			Console.WriteLine(index);
			//zadanie
			Console.Write("Wprowadź imię:");
			string name = Console.ReadLine();
			Console.WriteLine(name);

			string formattedName = FormatName(name);
			Console.WriteLine($"Sformatowane imię: {formattedName}");

			Console.ReadKey();
		}

		private static string FormatName(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return name;
			}

			return char.ToUpper(name[0]) + name.Substring(1).ToLower();
		}
	}
}
