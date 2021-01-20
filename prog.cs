using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            
            musteri.Ad = "Melike";
            musteri.Soyad = "Canbaz";
            musteri.Id = 16;
            musteri.Bakiye = 3654;
            musteri.Hesapturu = "Vadeli Mevduat Hesabı"


            Musteri musteriGuncelle = new Musteri();

            musteriGuncelle.Ad = "Melike";
            musteriGuncelle.Soyad = "Canbaz";
            musteriGuncelle.Id = 16;
            musteriGuncelle.Bakiye = 14750;
            musteriGuncelle.HesapTuru = "Fon Hesabı"

            Musteri musteriSil = new Musteri();

            musteriSil.Ad = "Melike";
            musteriSil.Soyad = "Canbaz";
            musteriSil.Id = 16;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri);
            musteriManager.MusteriGuncelle(musteriGuncelle);
            musteriManager.MusteriSil(musteriSil);



        }
    }
}