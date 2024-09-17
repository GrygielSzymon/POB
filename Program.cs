using System;

namespace typy_dannych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programowanie");
            Console.WriteLine("w języku C#");
            //komentarz w jednej lini
            /* 
             * komentarz
             * w wielu 
             * liniach
            */

            byte b = 0;
            //+ => konkatenacja
            Console.WriteLine("Zmienna b wynosi: " + b);

            sbyte sb = -127;
            Console.WriteLine("Zmienna sb wynosi: " + sb);

            short s = -2000;
            ushort us = 1000;
            //formatowanie ciągów za pomocą metody Console.WriteLine i indeksów miejsc w ciągu
            //Start sposób
            Console.WriteLine("Zmienna s wynosi; {0}, zmienna us wynosi; {1}", s, us);

            //interpolacja ciongów (nowszy sposób)
            Console.WriteLine($"Zmienna s wynosi: {s}, Zmienna us wynosi: {us}");

            Int16 i = 32767; //short
            Int16 ii = -32767; //short

            System.Int64 i2 = 999999999999999999;

            int i3 = 10;
            Int32 i4 = 10;
            System.Int64 i5 = 10;

            Console.WriteLine("Rozmiar typu bool: " + sizeof(bool));   //1 bajt

            float f = 10.5F;
            Console.WriteLine(f); //10.5
            Console.WriteLine("Rozmiar typu bool: " + sizeof(float));   //4 bajty => 32 bity

            long l = 10L;

            Console.WriteLine("Rozmiar typu double: " + sizeof(double) + "bajtów");      //8bajtów
            Console.WriteLine("Rozmiar typu decimal: " + sizeof(decimal) + "decimal");  //16 bajtów
            Console.WriteLine("Rozmiar typu char: " + sizeof(char) + "char");          //2 bajty

            decimal d = 10M;
            //Console.WriteLine(sizeof(decimal)); //16

            //System.Int128 = 10; nie występuje w .NET 8

            string text;
            text = d.ToString();
            Console.WriteLine(text);

            string text2 = 10.ToString();

            Console.WriteLine(text2);

            bool check = true;
            Console.WriteLine(check); //true

            check = false;
            Console.WriteLine(check); //false

            ushort us1 = 1;
            uint ui = 1U;
            ulong ul = 1UL;


            //systemy liczbowe
            //decymalny dziesiętny
            Console.WriteLine(11);

            //dwójkowy (binarny)
            //prefix 0b
            Console.WriteLine(0b101);

            ///ósemkowy (oktalny)
            //prefix 
            //brak natywnego wsparcia, możemy użyć konwersji z ciągu znaków
            int osemkowa = Convert.ToInt32("42", 8);
            Console.WriteLine(osemkowa); //34

            // szesnastkowy (heksadecymalny)
            //prefix 0x
            int szesnastkowa = 0x2B;
            Console.WriteLine(szesnastkowa); //43

            //konwersja liczby dziesiętnej na binarną
            int liczba = 33;
            string binarna = Convert.ToString(liczba, 2);
            Console.WriteLine(binarna); //100001


            Console.WriteLine(byte.MinValue); //0
            Console.WriteLine(byte.MaxValue); //225

            Console.WriteLine(sbyte.MinValue); //-128
            Console.WriteLine(sbyte.MaxValue); //127

            Console.WriteLine(int.MinValue);    //-214783648
            Console.WriteLine(Int32.MinValue); //-214783648

            Console.WriteLine(long.MinValue);  //-9223372036854775808
            Console.WriteLine(long.MaxValue); //9223372036854775807

            Console.ReadKey();

        }
    }
}