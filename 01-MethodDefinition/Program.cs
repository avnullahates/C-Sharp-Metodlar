using System;

namespace _01_MethodDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Methods:
            //Bir kod parcasini, program akisi icerisinde birden fazla yerde kullaniyorsak; metot olusturulmasi mantikli olan secenektir. Cunku, metot kullanimi ile daha az satirda kod yazilmis, daha merkezi kontrol olusturulmus, daha temiz kod yazilmis olur. 
            //If we use a piece of code in more than one place in the program flow; Creating a method is the logical option. Because, with the use of methods, fewer lines of code are written, more central control is created, and cleaner code is written.

            //Methods:
            /*
             1.  Geriye Deger Dondurmeyenler(void)
             1.1 Parametresiz Metotlar
             1.2 Parametreli Metotlar

             2.  Geriye Deger dondurenler(int, string, etc.)
             2.1 Parametresiz Metotlar
             2.2 Parametreli Metotlar

             */



            //-------Geriye Deger Dondurmeyen -Parametresiz:---------------------
            SumDo1();





            //---------Geriye Deger Donduren - Parametresiz:------------------------
            int sum = SumDo2();

            Console.WriteLine("Geriye deger donduren parametresiz metot sonucu: " + sum);
            Console.WriteLine("Geriye deger donduren parametresiz metot sonucu: " + SumDo2());






            //---------Geriye Deger Dondurmeyen- Parametreli---------------------------
            //Ornek: Kullanicidan alinan 3 tam sayiyin toplamini hesaplayip ekrana yazdiran metot.
            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 3: ");
            int num3 = int.Parse(Console.ReadLine());

            SumDo3(num1, num2, num3);
            SumDo3(120, 98, 54);
            //Console.WriteLine("Grilen 3 saytinin toplami: "+ SumDo3(23,85,47));// Hatalidir






            //-------------Geriye Deger donduren - Parametreli---------------------
            int sum1 = SumDo4(num1, num2, num3);
            Console.WriteLine("geriye deger donduren parametreli: " + sum1);
            Console.WriteLine("geriye deger donduren parametreli: " + SumDo4(16, 65, 17));







            //---------------------------Geriye FARKLI tipte deger donduren metot - Paramentreli------------------------
            string answer = SumDo5(15.6f, 14.2f);
            Console.WriteLine(answer);
            Console.WriteLine(SumDo5(13.2f, 58.4f));





            //Varsayilan Degere Sahip Parametreli Metot
            //Kullanicidan adini alan ve ekrana "Merhaba <Kullanici>!" seklinde bastiran bir metot olusturnuz. Ancak, kullanici adi girilmez ise Merhaba Dostum! seklinde ekrana yazilsin

            Console.Write("Enter your name: ");
            string incomeName = Console.ReadLine();

            Write(incomeName);
            //Eger girilen ad bilge adam ise ekrana("bilge adam")
            //Eger console ekraninda herhangi bir sey yazmadan ENTER a basilirsa, metot parametresiz cagirilmaz, ekrandan bos string deger alinir gibi kabul eder. bu sebeple Write() metodumuz, default degeri devereye sokamaz!

            Write();




            Console.ReadLine();


        }

        private static void Write(string incomeName = "Dostum")
        {
            Console.WriteLine($"Merhaba {incomeName}!");
        }

        static string SumDo5(float num1, float num2)
        {
            //Geriye FARKLI tipte deger donduren metot - Paramentreli
            float sum = num1 + num2;
            //return sum.ToString();
            //return (num1 + num2).ToString();
            return "Sum: " + sum;
        }

        static int SumDo4(int incomeNum1, int incomeNum2, int incomeNum3)
        {
            //Geriye Deger donduren - Parametreli
            // int sum1 = incomeNum1 + incomeNum2 + incomeNum3;
            //return sum1;
            return incomeNum1 + incomeNum2 + incomeNum3;
        }






        private static void SumDo3(int incomeNum1, int incomeNum2, int incomeNum3)
        {
            //Geriye Deger Dondurmeyen- Parametreli
            int sum = incomeNum1 + incomeNum2 + incomeNum3;
            Console.WriteLine("Girilen 3 sayinin toplami: " + sum);


        }





        private static int SumDo2()
        {
            //Geriye Deger Donduren - Parametresiz:
            int num1, num2;
            num1 = 15;
            num2 = 25;
            int sum = num1 + num2;
            return sum;
        }



        private static void SumDo1()
        {
            //Geriye Deger Dondurmeyen -Parametresiz:
            int num1, num2;
            num1 = 15;
            num2 = 25;
            int sum = num1 + num2;
            Console.WriteLine("Sum: " + sum);
        }





    }
}
