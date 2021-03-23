using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikiboyutludizii
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            Console.WriteLine("İsminizi teşrif eder misiniz?");
            ad = Console.ReadLine();
            Console.WriteLine("Soyunuzun devamını sağlayan soy isim nedir?");
            soyad = Console.ReadLine();


            Console.WriteLine("Ad: {0} Soyad: {1}", ad, soyad);
            Console.ReadKey();

            Console.Write("Vize notun nedir? Final daha önemli diye çok çalışmadığını ne zaman itiraf edeceksin?");
            float vize = Convert.ToSingle(Console.ReadLine());
            Console.Write("Final notun kaç? Yüzdesi daha çok olduğu için senden iyi bir performans bekliyorum! ");

            float final = Convert.ToSingle(Console.ReadLine());

            float ortalama = (float)(vize * 0.4) + (float)(final * 0.6);
            Console.WriteLine("\nNot Ortalamanız = " + ortalama);

            if (ortalama > 90)
            {
                Console.WriteLine("AA ile dersi geçtin, Tebrikler bro :)");
            }
            else if (ortalama > 80)
            {
                Console.WriteLine("BA ile dersi geçtin, iyisin iyi :)");
            }
            else if (ortalama > 70)
            {
                Console.WriteLine("BB ile dersi geçtin, fena değilsin! :)");
            }
            else if (ortalama > 60)
            {
                Console.WriteLine("CB ile dersi geçtin, biraz daha gayret:(");
            }
            else if (ortalama > 50)
            {
                Console.WriteLine("CC ile dersi geçtin, odaklanamıyor olabilir misin?");
            }
            else if (ortalama > 40)
            {
                Console.WriteLine("DC ile geçtin, sorunun ne dostum?");
            }
            else if (ortalama > 30)
            {
                Console.WriteLine("DD ile geçtin, kendini sorgulaman gerekiyor.");
            }
            else if (ortalama < 30)
            {
                Console.WriteLine("FF, doğru bölümde olduğuna emin misin dostum?");
            }
        }
    }
}


 