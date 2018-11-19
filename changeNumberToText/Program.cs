using System;

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
        
        Console.WriteLine(IsNumber);

        if (IsNumber == true)
        {
            Atsakymas(n, SkaiciusMin, SkaiciusMax);
        }
        else
        {
            Console.WriteLine("Ivestas simbolis nera skaicius");
        }
        Console.WriteLine("Skaicius zodziais: " + Isvedimas(n));
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

        static string Isvedimas(int n)
        {
            string[] Pavadinimai = new string[]
            {
            "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni",
            "desimt", "vienualika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika"
            };

            int indeksas = n;
            if (indeksas < 0)
                indeksas = indeksas * -1;

            string tekstas = Pavadinimai[indeksas];
            if (n < 0)
                tekstas = "minus " + tekstas;
        
        return tekstas;
        }

    }




