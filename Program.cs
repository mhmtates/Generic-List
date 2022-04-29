using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic(namespace)
            //T=>object türündedir.
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
            //Foreach ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            //Liste içerisinde arama 
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu.");
            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));
            //Diziyi List'e çevirme 
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);
            //Listeyi nasıl temizleriz?
            hayvanListesi.Clear();
            //List içerisinde nesne tutmak için 
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Faruk";
            kullanici1.Soyisim = "Arslan";
            kullanici1.Yas = 38;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "Selin";
            kullanici2.Soyisim = "Korkmaz";
            kullanici2.Yas = 24;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);
            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach (Kullanıcılar kullanıcı in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + ""+ kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:"+ "" + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı:" + "" +kullanıcı.Yas);
            } 
            yeniListe.Clear();
       }
    }

    public class Kullanıcılar
    {

        private string isim;
        private string soyisim;
        private int yas;

        //Encapsulation(get-set metodları)
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }


}
