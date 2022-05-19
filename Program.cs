using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, toplam;
            toplam = 0;
            string islem;
            Console.Write("Yapacağınız İşlemi Giriniz:");
            Console.WriteLine("Toplama için:+ Çıkarma için:- Çarpma için:* Bölme için:/ Yüzde için:%");
            islem = Console.ReadLine();
            if (islem == "%")
            {
                Console.Write("Sayıyı Giriniz:");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yüzdeyi Giriniz:");
                int yuzde = Convert.ToInt32(Console.ReadLine());
                toplam = sayi1 * yuzde / 100;
            }
            else
            {
                Console.Write("1. Sayıyı Giriniz:");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Sayıyı Giriniz:");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                if (islem == "+")
                {
                    toplam = sayi1 + sayi2;
                }
                else if (islem == "-")
                {
                    toplam = sayi1 - sayi2;
                }
                else if (islem == "*")
                {
                    toplam = sayi1 * sayi2;
                }
                else if (islem == "/")
                {
                    toplam = sayi1 / sayi2;
                }
                else
                {
                    Console.Write("Hatalı Giriş:");
                }
            }
            Console.WriteLine("İşlem Sonucunuz {0}", toplam);
            Console.ReadKey();
        }
    }
}
