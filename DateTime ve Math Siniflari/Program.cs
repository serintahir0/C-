using System;

namespace degisken{

    class Program{
        static void Main(string[] args){

            Console.WriteLine(DateTime.Now); //andaki tarihi getirir
            Console.WriteLine(DateTime.Now.Date); //andaki tarihi getirir
            Console.WriteLine(DateTime.Now.Day); //gunu getirir
            Console.WriteLine(DateTime.Now.Month); //ayi getirir
            Console.WriteLine(DateTime.Now.Year); //yili getirir
            Console.WriteLine(DateTime.Now.Hour); //saati getirir
            Console.WriteLine(DateTime.Now.Minute); //dakikayi getirir
            Console.WriteLine(DateTime.Now.Second); //saniyeyi getirir

            Console.WriteLine(DateTime.Now.DayOfWeek); //haftanın kacinci gunu oldugunu getirir
            Console.WriteLine(DateTime.Now.DayOfYear); //yilin kacinci gunu oldugunu getirir

            Console.WriteLine(DateTime.Now.ToLongDateString()); //tarihi string ile getirir
            Console.WriteLine(DateTime.Now.ToLongTimeString()); //saati string ile getirir
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(5));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddSeconds(5));
            Console.WriteLine(DateTime.Now.AddYears(5));
            Console.WriteLine(DateTime.Now.AddMinutes(5));
            Console.WriteLine(DateTime.Now.AddHours(5)); 
            Console.WriteLine(DateTime.Now.AddMilliseconds(5));

            //Datetime Format
            
            Console.WriteLine(DateTime.Now.ToString("dd")); //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday 

            Console.WriteLine(DateTime.Now.ToString("MM")); //04
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Apr
            Console.WriteLine(DateTime.Now.ToString("MMMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy")); //22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

            //Math Kütüphanesi

            Console.WriteLine(Math.Abs(-32)); //negatif verilen degeri pozitif hale getirir : 32
            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Cos(30));
            Console.WriteLine(Math.Tan(30));
            
            Console.WriteLine(Math.Ceiling(22.3)); //sayidan büyük en kucuk tamsayiyi getirir
            Console.WriteLine(Math.Round(22.3)); //ust tamsayi veya alt tamsayidan hangisine yakinsa onu getirir : 22
            Console.WriteLine(Math.Round(22.8)); //ust tamsayi veya alt tamsayidan hangisine yakinsa onu getirir : 23
            Console.WriteLine(Math.Floor(22.3)); //sayidan kucu en buyuk tamsayiyi getirir

            Console.WriteLine(Math.Max(22,3)); 
            Console.WriteLine(Math.Min(22,3)); 
            Console.WriteLine(Math.Pow(2,3)); //2 üstü 3
            Console.WriteLine(Math.Sqrt(9)); //karekok
            Console.WriteLine(Math.Log(9)); //9 un e tabanındaki logaritmik karsiligini getirir
            Console.WriteLine(Math.Log10(9)); //9 un 10 tabanındaki logaritmik karsiligini getirir
            Console.WriteLine(Math.Exp(9)); //e uzeri 9 getirir

        }
    }
}