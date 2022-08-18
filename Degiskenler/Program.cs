using System;

namespace degisken{

    class Program{
        static void Main(string[] args){

            byte b = 5;   // bellekte 1 byte yer kaplar 
            sbyte sb = 5;   // bellekte 1 byte yer kaplar 
           
            short sh = 5;   // bellekte 2 byte yer kaplar 
            ushort ush = 5;    // bellekte 2 byte yer kaplar 

            int i = 5;   // bellekte 4 byte yer kaplar 
            Int16 i16 = 5;   // bellekte 2 byte yer kaplar 
            Int32 i32 = 5;   // bellekte 4 byte yer kaplar 
            Int64 i64 = 5;   // bellekte 8 byte yer kaplar 

            uint ui = 5;   // bellekte 4 byte yer kaplar 
            long l = 5;   // bellekte 8 byte yer kaplar
            ulong ul = 5;   // bellekte 8 byte yer kaplar

            float f = 5;   // bellekte 4 byte yer kaplar
            double d = 5;   // bellekte 8 byte yer kaplar
            decimal dec = 5;   //bellekte 16 byte yer kaplar 

            char c = 'a' ; //tek bir karakteri tutmak istersek char kullanırız. Bellekte 2 byte yer kaplar
            string str = "tahir"; //birden fazla karakteri tutmak istersek string kullanırız. Bellekte sınırsız yer kaplar

            bool bl = true; //
            DateTime dt = DateTime.Now; //o anki tarih ve saati verir

            object o1 = 'x';
            object o2 = 3;
            object o3 = "tahir";
            object o4 = 4.3;
            //object değişkeni tüm değişkenlerin yerine kullanılabilir.

            string str1 = string.Empty; //stringe boş atandı
            str1 = "tahir"; //boş olan değişkene bir metin atandı
            string ad = "tahir";
            string soyad = "serin";
            string tamisim = ad + " " + soyad ; //tamisim stringine ad ve soyadı atadık

            bool bool1 = 10>2 ; //bool1 değerine "true" atanır

            //değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString(); //int20 değişkenini stringe dönüştürdük
            int int40 = int20 + Convert.ToInt32(str20); //str20 değişkenini int32 değerine dönüştürdük

            int int22 = int20 + int.Parse(str20); //str20 değişkenini int'e çevirip int20 ile topladık.
            //eğer str20 değişkeni içinde sayı değil de metin karakteri vb olsaydı hata verirdi.

            string datetime2 = DateTime.Now.ToString("dd.MM.yyyy - hh:mm");


            Console.WriteLine(datetime2);
        }
    }
}