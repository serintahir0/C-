using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            string degisken = "Dersimiz Csharp, Hosgeldiniz!";
            string degisken2 = "dersimiz Csharp Hosgeldiniz!";
            string degisken3 ="Csharp";

            //Length 
            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken,"Merhaba!")); 
            //Concat 1. de aldigi string parametresi ile 2. de aldigi stringi birlestirir.

            //CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); 
            //1. degisken 2. degiskenden daha buyuk karakter sayisina sahipse 1 dondurur.
            //1. degisken 2. degiskenden daha kucuk karakter sayisina sahipse -1 dondurur.
            //1. degisken karakter sayisi 2. degisken karakter sayisina esitse 0 dondurur.

            //Compare
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            //CompareTo ile aynı işlevi yapar
            //Ignore Case : true anahtar kelimesi buyuk kucuk harf duyarlılığını kapatır.
            //false ise buyuk kucuk harf duyarliligini acar.

            //Contains
            Console.WriteLine(degisken.Contains(degisken3)); 
            //degisken icinde degisken3 aranir. Bulursa true dondurur.

            //EndsWith
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!")); //degisken "Hosgeldiniz!" ifadesiyle bitiyor mu (t/f)
            //StartsWith
            Console.WriteLine(degisken.StartsWith("Merhaba")); //degisken "Merhaba" ifadesiyle baslıyor mu (t/f)

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS")); // degisken icinde "CS" ifadesini ilk buldugu yerde
            //(C nin basladigi yerde) bulunan index'i dondurur.
            //Hic bir sey bulamazsa -1 dondurur.

            //LastIndexOf
            Console.WriteLine(degisken.LastIndexOf("i")); //sondan baslayarak "i" ifadesini arar ve index'ini dondurur.

            //Insert
            Console.WriteLine(degisken.Insert(0,"Kalem")); //verilen indexten baslayıp verilen ifadeyi diziye ekler.

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*')); 
            //degisken2 stringinin soluna degisken2 ile birlikte 30 karakter oluncaya kadar * ekler.
            //yani ornegin degisken = "elma", degisken2 = "armut"
            //output : elma*************************armut 
            //elmadan sonra 25 adet * ve armut ifadesi mevcuttur.

            Console.WriteLine(degisken + degisken2.PadLeft(30)); 
            //degisken2 nin soluna 30-(degisken2 karakter sayisi) kadar bosluk ekler.

            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'_') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10)); //10. indexten baslayarak sona kadar siler. 10. indexten oncesini dondurur.
            Console.WriteLine(degisken.Remove(5,3)); //5. indexten baslayarak 3 karakter siler.
            Console.WriteLine(degisken.Remove(0,1)); //0. indexten baslayarak 1 karakter siler. (bastaki karakteri siler)
            
            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#")); // "Csharp" ifadelerini "C#" ile degistirir.
            Console.WriteLine(degisken.Replace(" ", "*")); //boslukları yildiz ile degistirir.

            //Split
            Console.WriteLine(degisken.Split(' ')[1]); 
            //degisken stringini bosluklara gore ayirir ve bir diziye atar. Ardindan bu dizinin 1. index'ini dondurur.

            //Substring
            Console.WriteLine(degisken.Substring(4)); //4. indexten baslayarak ifadenin sonuna kadar olan karakterleri getirir.
            Console.WriteLine(degisken.Substring(4,6)); //4. indexten baslayarak ifadenin 6 karakterini getirir.





            




        }   
    }
}