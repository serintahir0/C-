using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:{
                   Console.WriteLine("Ocak Ayındasınız.");
                    break; 
                }
                case 2:{
                   Console.WriteLine("Şubat Ayındasınız.");
                    break; 
                }
                case 3:{
                   Console.WriteLine("Mart Ayındasınız.");
                    break; 
                }
                //Not case'lerin sırasının önemi yoktur. Şart hangi case'e uyuyorsa o çalışır.
                case 6:
                case 7:
                case 8:{
                    Console.WriteLine("Yaz mevsimindesiniz");
                    break;
                }
                //3 farklı case'de aynı işlemi yapmak istiyorsak kodu bu şekilde yazarı.
                

                
                default:{
                    Console.WriteLine("Yanlış veri girişi");
                }
                //default -> hiçbir case'e uymayan işlemleri burda yaptırırız.
                break;
            }

        }
    }
}