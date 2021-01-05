using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------\n" +
                "- BOY KİLO ENDEKSİ -\n" +
                "---------------------\n" +
                "\nLütfen gerekli bilgilerini giriniz.");

            try
            {
                Console.Write("\nKilonuz (kg) : ");
                double weight = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nBoyunuz (cm) : ");
                double heihgt = Convert.ToDouble(Console.ReadLine());

                heihgt /= 100;
                double bmi = weight / Math.Pow(heihgt, 2);
                string result = bmi.ToString("0.###");

                Console.Write($"\nSonucunuz :\n-> BMI : {result}  ");

                if (bmi < 18.5)
                    Console.WriteLine("(Zayıf)");
                else if (bmi >= 18.5 && bmi < 25)
                    Console.WriteLine("(Normal)");
                else if (bmi >= 25 && bmi < 30)
                    Console.WriteLine("(Kilolu)");
                else if (bmi >= 30 && bmi < 35)
                    Console.WriteLine("(Obez)");
                else if (bmi >= 35)
                    Console.WriteLine("(Aşırı Obez)");

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
