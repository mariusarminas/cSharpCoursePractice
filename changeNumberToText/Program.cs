using System;

class Program
{

    static void Main()
    {
        //Sukurti funkciją kuri patikrina ar tekstas yra skaičius. Grąžina true jei teisingas.

        int SkaiciusMin = -9;
        int SkaiciusMax = 9;
        int n;
        Console.WriteLine("Iveskite skaiciu");
        string Skaicius = Console.ReadLine();
        var IsNumber = int.TryParse(Skaicius, out n);
        Console.WriteLine(IsNumber);
        Console.ReadKey();

    }

}


//Sukurti funkciją kuri konvertuoti string į int, patikrinti ar skaičius teisinguose rėžiuose: -9 ... 9.
class Program
{

    static void Main()
    {
int SkaiciusMin = -9;
int SkaiciusMax = 9;
int n;
Console.WriteLine("Iveskite skaiciu");
            string Skaicius = Console.ReadLine();
var IsNumber = int.TryParse(Skaicius, out n);
        if (IsNumber == true)
        {
            Atsakymas(n, SkaiciusMin, SkaiciusMax);
        }
        else
        {
            Console.WriteLine("Ivestas simbolis nera skaicius");
        }
            Console.ReadKey();
        }
    static void Atsakymas(int n, int SkaiciusMin, int SkaiciusMax)
    {
        if (n > SkaiciusMin && n < SkaiciusMax)
        {
            Console.WriteLine("Skaicius patenka i " + SkaiciusMin + " ir " + SkaiciusMax + " rezius");
        }
        else
        {
            Console.WriteLine("Skaicius nepatenka i " + SkaiciusMin + " ir " + SkaiciusMax + " rezius");
        }
    }




    //sukurti funkciją, kuri gali atspausdinti skaičius nuo -19 … 19
    class Program
{

    static void Main()
    {
            int Skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Isvedimas(Skaicius));
            Console.ReadKey();
        }

        string Isvedimas(int skaicius)
        {
            string[] Pavadinimai = new string[]
            {
            "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni",
            "desimt", "vienualika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika"
            };

            int indeksas = skaicius;
            if (indeksas < 0)
                indeksas = indeksas * -1;

            string tekstas = Pavadinimai[indeksas];
            if (skaicius < 0)
                tekstas = "minus " + tekstas;

            return tekstas;
        }





    }
}
