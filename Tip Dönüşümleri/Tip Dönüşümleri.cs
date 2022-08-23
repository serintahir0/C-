using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            //İmplicit Conversion (Bilinçsiz Dönüşüm) : 
            //C#'ın kendi kendine yapabildiği dönüşümler
            //Bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanmasıdır. 

            byte a = 5;
            sbyte b =30;
            short c = 122;
            int d = a + b + c;
            Console.WriteLine("d:" + d);
 
            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine ("i:" + i);

            string e = "Tahir";
            char f = 't';
            object g = e + f + d;
            Console.WriteLine(g);

            //Explicit Conversion (Bilinçli Dönüşüm) : 
            //C# 'ın kendi kendine yapamadığı dönüşümler

            int x = 4 ;
            byte y = (byte)x; //başına (byte) yazdığımız için derleyici x değişkenini byte tipine dönüştürmeye çalışır.
            Console.WriteLine("y:" + y);

            int z = 100; 
            byte t = (byte)z;
            Console.WriteLine("z:" + z);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            //ToString Methodu
            //int float gibi değişkenleri stringe çevirmek için kullanılır

            int sayi1 = 3;
            string sayi2 = sayi1.ToString();

            float sayi3 = 22.34f;
            string sayi4 = sayi3.ToString();
            Console.WriteLine("sayi2 : " + sayi2 + "sayi4 : " + sayi4);

            //System.Convert 
            string s1 ="10", s2 = "20";
            int sayi01, sayi02;
            int toplam=0;

            sayi01 = Convert.ToInt32(s1);
            sayi02 = Convert.ToInt32(s2);
            toplam = sayi01 + sayi02;
            Console.WriteLine ("toplam: " + toplam);

            //Parse 
            //Bu method stringleri tamsayılara dönüştürür
            ParseMethod();
        }

        public static void ParseMethod(){
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1 ;
            double double1;
            

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            
            Console.WriteLine(rakam1);
            Console.WriteLine(double1);
        }
    }
}