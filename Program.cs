using System;

namespace string_metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // şimdi 
            Console.WriteLine(DateTime.Now.Date); // tarih 
            Console.WriteLine(DateTime.Now.Day); // gün
            Console.WriteLine(DateTime.Now.Month);  // ay
            Console.WriteLine(DateTime.Now.Year);  //yıl
            Console.WriteLine(DateTime.Now.Hour); //saat
            Console.WriteLine(DateTime.Now.Minute); // dakika
            Console.WriteLine(DateTime.Now.Second); // saniye


            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.DayOfWeek);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(7));
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(23));

            //datetime format

            Console.WriteLine(DateTime.Now.ToString("dd"));  //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); //sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); //02
            Console.WriteLine(DateTime.Now.ToString("MMM"));    //Feb
            Console.WriteLine(DateTime.Now.ToString("MMMM"));   //February


            Console.WriteLine(DateTime.Now.ToString("yy"));     //22
            Console.WriteLine(DateTime.Now.ToString("yyyy"));   //2022
            

            //MATH

            Console.WriteLine(Math.Abs(-25));       //Mutlak değer
            Console.WriteLine(Math.Sin(30));        //Sinüs
            Console.WriteLine(Math.Cos(30));        //Cosinüs
            Console.WriteLine(Math.Tan(30));        //Tanjant
            Console.WriteLine(Math.Ceiling(10.6));  //Bir üst sayı
            Console.WriteLine(Math.Round(10.6));    //Yuvarla
            Console.WriteLine(Math.Floor(10.6));    //Taban


            Console.WriteLine(Math.Max(2,6));       //6
            Console.WriteLine(Math.Min(2,6));       //2

            Console.WriteLine(Math.Pow(3,4));       //3^4
            Console.WriteLine(Math.Sqrt(9));        //3
            Console.WriteLine(Math.Log(10));        //logaritma
            Console.WriteLine(Math.Exp(3));         //e^3

            Console.WriteLine(Math.Log10(10));      //logaritma 10 tabanında
            






        }
    }
}
