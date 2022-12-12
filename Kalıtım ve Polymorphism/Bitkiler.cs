using System;

namespace Patika{

    public class Bitkiler:Canlilar{
        public Bitkiler(){ //constructor
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            //base.UyaranlaraTepki(); //bitkiler uyaranlara tepki vermesin diye cıkardık
            //artık bitkiler canlılar üst class'ından uyaranlara tepki verir metodunu kullanamaz
            //fakat hayvanlar hala kullanabilir
        }
        protected void FotosentezYapmak(){
            Console.WriteLine("Bitkiler fotosentez yapar."); 
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler uyaranlara tepki verir");
        }
    }

    public class TohumluBitkiler:Bitkiler{
        public TohumluBitkiler(){ //constructor
            base.FotosentezYapmak(); //base anahtar kelimesi ile bir üst class'a erişiriz
        }

        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler{
        public TohumsuzBitkiler(){ //constructor
            base.FotosentezYapmak(); 
        }
        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
}