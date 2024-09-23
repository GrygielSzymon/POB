int i = 10;
System.Int16 i1 = 10;
System.Int32 i2 = 10;  //int
System.Int64 i3 = 10;  //long

short i5 = 10;
long i4 = 10L;

byte i6 = 10;    //0 do 255
sbyte i7 = 100;  //-128 do 127

int i = 10; //32 bity - 4 bajty
int16 j = 10; // 16 bitów - 2 bajty
System.Int64 k = 10; //64 bity - 8 bajtów

long l1 = 10L //System.Int64

float f = 10.5f; // 4 bajty

double d = 10.5; // 8 bajtów
decimal dec = 10.5M; //16 bajtów

Console.WriteLine(sizeof(Int32));   // 4
Console.WriteLine(sizeof(byte));    // 1 bajt
Console.WriteLine(sizeof(short));   // 2 bajty => Int16
Console.WriteLine(sizeof(char));    // 2 bajty

Console.WriteLine(byte.MinValue);  // 0 - bitów
Console.WriteLine(byte.MaxValue);  // 255

Console.WriteLine(sbyte.MinValue);  // -128
Console.WriteLine(sbyte.MaxValue);  // 127

Console.WriteLine(int.MinValue);  //-2147483648
Console.WriteLine(int.MaxValue);  //2147483647

Console.WriteLine(Int32.MinValue);  // -2147483648
Console.WriteLine(Int32.maxValue);  // 2147483647

Console.WriteLine(long.MinValue);  //-9223372036854775808
Console.WriteLine(long.MaxValue); //9223372036854775807

// ushort, uint, ulong 
Console.WriteLine(sizeof(ushort));  // 2 bajty

int x = 100;
string xstring = x.Tostring();
xstring = 50.ToString;

//int, long, float, double oraz string są aliasami nazw typów
int i = 10;
System.Int32 number = 100;

int i = 10;    // typ int
Long l = 10L;  // typ long
float f = 10.0f;    //typ float
doubled = 10.0;     //typ double

ushort x3 =2;
uint x4 = 3U;
ulong x5 = 4UL;

bool check = true;
Console.WriteLine(check);
bool check1 = false;
Console.WriteLine(check1);

// typ = int  nazwa = i  int i;

string binaryNumber = "101010";    //liczba binarna
int decimalNumber = Conwert.ToInt32(binaryNumber, 2);  //konwersja na system dziesiętny 
string hexNumber = decimalNumber.ToString("X");  //konwersja na system szesnastkowy 

Console.WriteLine($"Liczba binarna: {BinaryNumber}");  //101010
Console.WriteLine($"Liczba szesnastkowa: {hexNumber}");  //2A

//Liczby w systemie binarnym są poprzedzone prefixem 0b lub 0B (prefiks - przedrostek)
inr BinaryNumber = 0B11111111;
Console.Writeline(binaryNumber);   //Wyjście: 255
Console.WriteLine(ob1011); //11

//To standardowy system liczbowy, którego urzywamy na co dzień. liczby są zapisywane bez żadnych prefiksów
int decimalNumber = 255;
Console.WriteLine(ddecimalNumber); //Wyjście: 255 

//W C# możan pracować z systemami liczbowymi takimi jak:
// dziesiętny
// szesnastkowy
// ósemkowy
// binarny

//Zmienne można zadeklarować w dowolnym miejscu  metod i klas
