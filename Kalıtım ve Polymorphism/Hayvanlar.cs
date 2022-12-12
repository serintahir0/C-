using System;

namespace Patika{

    public class Hayvanlar: Canlilar{
        public Hayvanlar(){ //constructor
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        protected void SuruHalindeHareket(){
            Console.WriteLine("Hayvanlar sürüler halinde hareket eder."); 
        }

        public override void UyaranlaraTepki() //override 
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }

    public class Kus:Hayvanlar{
        public Kus(){ //constructor
            base.SuruHalindeHareket(); 
        }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçar");
        }
    }

    //bir sınıftan hiç bir sınıf türetilememesi için 
    //(o sınıfın hiç bir sınıfa kalıtım verememesi için) :
    //sealed anahtar kelimesi kullanılır. Ordek class'ında bunu kullandık.
    //Artık Ordek class'ı hiç bir class'a kalıtım veremez. Kısır ettik :D
    //sealed kalıtımı engellemek icin kullanılır

    public sealed class Ordek:Hayvanlar{
        public Ordek(){ //constructor
            base.SuruHalindeHareket(); 
        }
        public void Yuzmek(){
            Console.WriteLine("Ördekler yüzer");
        }
    }
}

