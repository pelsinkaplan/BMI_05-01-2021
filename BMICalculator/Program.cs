using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------\n" +
                "- BMI Hesaplayıcıya Hoşgeldiniz! -\n" +
                "----------------------------------\n" +
                "\nLütfen gerekli bilgilerini giriniz.");

            try
            {
                Console.Write("\nBoy : ");
                double boy = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nKilo : ");
                double kilo = Convert.ToDouble(Console.ReadLine());

                boy /= 100;
                double bmi = kilo / Math.Pow(boy, 2);

                Console.Write("\nSonucunuz : ");

                if (bmi < 18.5)
                    Console.WriteLine("Zayıf");
                else if (bmi >= 18.5 && bmi < 25)
                    Console.WriteLine("Normal");
                else if (bmi >= 25 && bmi < 30)
                    Console.WriteLine("Kilolu");
                else if (bmi >= 30 && bmi < 35)
                    Console.WriteLine("Obez");
                else if (bmi >= 35)
                    Console.WriteLine("Aşırı Obez");

                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen bir sayı giriniz!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Kilo veya boy değeri 0 olamaz!");
            }
            catch (Exception hata)
            {
                Console.WriteLine("Bir hata meydana geldi : " + hata);
            }

        }
    }
}
