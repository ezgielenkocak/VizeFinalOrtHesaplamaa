using System;

namespace VizeFinalOrtHesaplamaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç Öğrenci Kayıt Etmek İstiyorsunuz? : ");
            byte kayit = byte.Parse(Console.ReadLine());
            object[,] ogrenciler = new object[kayit + 1, 6];
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "Vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Ortalama";
            ogrenciler[0, 5] = "Harf notu";
            double ort = 0;
            for (int i = 1; i < ogrenciler.GetLength(0); i++)
            {
                Console.Write("Öğrencinin adını giriniz :");
                ogrenciler[i, 0] = Console.ReadLine();
                Console.Write("Öğrencinin soyadını giriniz :");
                ogrenciler[i, 1] = Console.ReadLine();
                Console.Write("Öğrencinin vizesini giriniz:");
                ogrenciler[i, 2] = Console.ReadLine();
                Console.Write("Öğrencinin finalini giriniz:");
                ogrenciler[i, 3] = Console.ReadLine();
                int viz = Convert.ToInt32(ogrenciler[i, 2]);
                int fin = Convert.ToInt32(ogrenciler[i, 3]);
                ort = ((0.4) * viz + (0.6) * fin);
                ogrenciler[i, 4] = ort;

                if (ort >= 89 && ort<=100)
                {
                    ogrenciler[i, 5] = "         AA";
                }
                else if (ort >= 79 && ort <= 88)
                {
                    ogrenciler[i, 5] = "        BA";
                }
                else if (ort >= 69 && ort <= 78)
                {
                    ogrenciler[i, 5] = "        BB";
                }
                else if (ort >= 60 && ort <= 68)
                {
                    ogrenciler[i, 5] = "        CB";
                }
                else if (ort >= 50 && ort <= 59)
                {
                    ogrenciler[i, 5] = "        CC";
                }
                else if (ort >= 40 && ort <= 49)
                {
                    ogrenciler[i, 5] = "        DC";
                }
                else if (ort >= 31 && ort <= 39)
                {
                    ogrenciler[i, 5] = "        DD";
                }
                else if (ort >= 25 && ort <= 30)
                {
                    ogrenciler[i, 5] = "        FD";
                }
                else
                {
                    ogrenciler[i, 5] = "        FF";
                }


            }


            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i, j] + "\t"); 
                }
                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
