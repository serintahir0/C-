using System;

namespace Patika{

    public class Canlilar {
        protected void Beslenme(){
            Console.WriteLine("Canlılar beslenir.");        
        }

        protected void Solunum(){
            Console.WriteLine("Canlılar solunum yapar."); 
        }

        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım Yapar."); 
        }

        public virtual void UyaranlaraTepki(){
            Console.WriteLine("Canlılar uyaranlara tepki verir");
        }
    }
}