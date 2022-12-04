using System;
using System.Collections.Generic; //Koleksiyonların bulundugu namespace

namespace degisken{

    class Program{
        static void Main(string[] args){
            //List<T> class
            //T --> object türündedir

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(2);
            sayiListesi.Add(3);
            sayiListesi.Add(5);
            sayiListesi.Add(93);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Mavi");
            renkListesi.Add("Beyaz");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Kirmizi");
            renkListesi.Add("Yesil");
            renkListesi.Add("Sari");

            //listelerde count islemi

            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            int a = sayiListesi.Count;
            Console.WriteLine(a);
            

            foreach(var sayi in sayiListesi){
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi){
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); //tek satirda foreach ile yazdirma
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //listeden eleman cikarma
            sayiListesi.Remove(34); //34 elemanini sayiListesi'nden cikar
            renkListesi.Remove("Yesil"); //Yesil elemanini renkListesi'nden cikar

            sayiListesi.RemoveAt(0); //sayiListesi'nden 0. index'li elemani cikarir
            renkListesi.RemoveAt(1); //renkListesi'nden 1. index'li elemani cikarir

            //List icinde arama
            if(sayiListesi.Contains(23)){
                Console.WriteLine("sayi bulundu");
            }

            //eleman ile index'e erisme
            Console.WriteLine(renkListesi.BinarySearch("Sari"));

            //diziyi listeye cevirme

            string[] hayvanlar =  {"kedi","kopek","at"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //tüm listeyi temizleme
            hayvanListesi.Clear();

            //list icinde nesne tutma
            List<Kullanicilar> kullanicilarListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim="Ali";
            kullanici1.Soyisim ="Gürses";
            kullanici1.Yas = 32;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim="Ayse";
            kullanici2.Soyisim ="Gökler";
            kullanici2.Yas = 23;

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){ //yeniListe List'ine Kullanıcılar sinifindan yeni bir eleman ekliyoruz
                Isim = "Tahir",
                Soyisim = "Serin",
                Yas =26
            });

            foreach (var kullanici in kullanicilarListesi){
                Console.WriteLine("Kullanici Adi:"+kullanici.Isim);
                Console.WriteLine("Kullanici Adi:"+kullanici.Soyisim);
                Console.WriteLine("Kullanici Adi:"+kullanici.Yas);
            }



        }
    }

    public class Kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
        
}