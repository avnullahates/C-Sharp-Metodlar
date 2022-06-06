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

            


            SumDo1();



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
