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

/*
 * To jest
                wieloliniowy
                ciąg znaków 
 *       
*/

//metody manipulacji ciągamia
//replace
string Text = "Programowanie obiektowe";
string newText =Text.Replace("obiektowe", "strukturalne");
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
char[] separators = { ';', ','};
string[] words2 = sentence2.Split(separators);
foreach(string word in words2)
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


//Join, SubString, ToUpper, ToLower, IndexOff





Console.ReadKey();
