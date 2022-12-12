using System;

namespace Patika{

    class Kalitim_ve_Polymorphism{
        static void Main(string[] args){
        
        //                  Canlılar
        //      Bitkiler                    Hayvanlar
        // Tohumlu   Tohumsuz        Sürüngenler     Kuşlar
        
        TohumluBitkiler tohumluBitki = new TohumluBitkiler();
        
        
        tohumluBitki.TohumlaCogalma();

        Console.WriteLine("**********************");

        Ordek ordek = new Ordek();
     
        ordek.Yuzmek(); 
        
        }
    }
}
// Çocuk_Class : Ata_Class 
// iki noktadan önceki kalıtım alan, iki noktadan sonraki kalıtım veren

//Çok biçimcilik ile birlikte hayatımıza sanal yani virtual metotlar giriyor. 
//Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız. 
//Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan 
//ve daha sonra alt sınıflarda yeniden yazılabilen metotlardır. 
//Bunu da virtual ve override anahtar kelimeleri sağlar.

//bir sınıftan hiç bir sınıf türetilememesi için 
//(o sınıfın hiç bir sınıfa kalıtım verememesi için) :
//sealed anahtar kelimesi kullanılır