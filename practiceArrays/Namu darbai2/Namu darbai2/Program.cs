using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_darbai2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int nuo = 100000;
                int iki = 999999;
                int[] masyvas = new int[iki - nuo + 1];
            
                int indeksas = 0;
                for (int i = nuo; i <= iki; i++)
                {
                    masyvas[indeksas] = i;
                    indeksas = indeksas + 1;
                }

                // SpausdintiMasyva(masyvas);
                for (int i = 0; i < masyvas.Length; i++)
                {
                    int skaicius = masyvas[i];

                    int[] skaiciai = IsskaidytiIMasyva(skaicius);
                    int[] skaiciai2 = IsskaidytiIMasyva(skaicius * 2);
                    int[] skaiciai3 = IsskaidytiIMasyva(skaicius * 3);
                    int[] skaiciai4 = IsskaidytiIMasyva(skaicius * 4);
                    int[] skaiciai5 = IsskaidytiIMasyva(skaicius * 5);
                    int[] skaiciai6 = IsskaidytiIMasyva(skaicius * 6);

                    if (ArTuriVisusSkaicius(skaiciai2, skaiciai) &&
                        ArTuriVisusSkaicius(skaiciai3, skaiciai) &&
                        ArTuriVisusSkaicius(skaiciai4, skaiciai) &&
                        ArTuriVisusSkaicius(skaiciai5, skaiciai) &&
                        ArTuriVisusSkaicius(skaiciai6, skaiciai))
                    {
                        Console.WriteLine("Magiskas skaicius: " + skaicius);
                        SpausdintiMasyva(skaiciai2);
                        SpausdintiMasyva(skaiciai3);
                        SpausdintiMasyva(skaiciai4);
                        SpausdintiMasyva(skaiciai5);
                        SpausdintiMasyva(skaiciai6);
                        Console.ReadKey();
                }
                }
            }
        
            static void SpausdintiMasyva(int[] masyvas)
            {
                for (int i = 0; i < masyvas.Length; i++)
                    Console.Write(masyvas[i] + " ");

                Console.WriteLine();
            }

            static bool ArTuriVisusSkaicius(int[] masyvas, int[] skaiciai)
            {
                if (masyvas.Length != skaiciai.Length)
                    return false;

                for (int i = 0; i < skaiciai.Length; i++)
                {
                    if (!ArTuriSkaiciu(masyvas, skaiciai[i]))
                        return false;
                }
                return true;
            }

            static bool ArTuriSkaiciu(int[] masyvas, int skaicius)
            {
                for (int i = 0; i < masyvas.Length; i++)
                {
                    if (masyvas[i] == skaicius)
                        return true;
                }

                return false;
            }

            static int[] IsskaidytiIMasyva(int skaicius)
            {
                int ilgis = 0;
                int skaicius2 = skaicius;
                do
                {
                    skaicius2 /= 10;
                    ilgis++;
                }
                while (skaicius2 > 0);

                int[] masyvas = new int[ilgis];

                skaicius2 = skaicius;
                int indeksas = 0;

                do
                {
                    masyvas[indeksas] = skaicius2 % 10;
                    indeksas = indeksas + 1;
                    skaicius2 /= 10;
                }
                while (skaicius2 > 0);

                return masyvas;
            }
        }
    }

