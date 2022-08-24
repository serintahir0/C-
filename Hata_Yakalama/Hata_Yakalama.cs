using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
           /*
            try{    //try içine, hataya sebebiyet verme ihtimali olan kod yazılır
                Console.WriteLine("Bir tamsayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiginiz sayi: " + sayi);
            }
            catch(Exception hata1){  //Hata ile karşılaşıldığında ne yapılacağı buraya yazılır
                Console.WriteLine("Hata: " + hata1.Message.ToString());
            }
            finally{    //Hata olsun ya da olmasın (koşuldan bağımsız) çalıştırılmasını istenilen bir kod bloğu varsa finally içine yazılır
                Console.WriteLine("İşlem tamamlandı.");
            }
            */

            /*
            try{
                int a = int.Parse(null);
            }
            catch(ArgumentNullException hata2){  //Hata NullException hatası ise
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(hata2);
            }
            */
            
            /*
            try{
                int a = int.Parse(null);
            }
            catch(FormatException hata3){
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(hata3);
            }
            */

            try{
                int a = int.Parse("-59200000201");
            }
            catch(OverflowException hata4){
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(hata4);
            }
            finally{
                Console.WriteLine("işlem başarıyla tamamlanmıştır.");
            }

        }
    }
}