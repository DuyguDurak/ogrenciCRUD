using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_12_2023_2
{
    internal class Program
    {
        static List<string> _ogrenciAd = new List<string>();
        static void Main(string[] args)
        {
            //Ekleme metodu oluşturalım ve kullanıcıdan ad bilgisi isteyelim.

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Eklemek istediğiniz öğrencinin adını giriniz : ");
                OgrenciEkle(Console.ReadLine());
            }

            //Aldığımız bu bilgileri metot ile _ogrenciAd listesine ekleyelim.

            //Listeleme metodu oluşturup tüm listeyi ekranda gösterelim
            OgrenciList();
            //Güncelleme metodu oluşturup kullanıcıdan önce ismini değiştirmek istediğimiz kişinin adını daha sonra
            //hangi isimle değiştireceğimizi sorup yeni adı alalım ve isim değiştirme yapalım
            Console.WriteLine("Güncellemek istediğiniz ismi yazınız : ");

            string guncellenecekisim = Console.ReadLine();
            Console.WriteLine("Yeni ismi giriniz : ");
            string guncelisim = Console.ReadLine();

            OgrenciGuncelle(guncellenecekisim,guncelisim);





            //Tekrar listenin son halini ekranda göstereliim
            OgrenciList();
            //Silme metodu yapıp Adını aldığımız kişiyi listeden silelim
            //Tekrar listenin son halini ekranda gösterelim.
            Console.WriteLine("Silmek istediğiniz öğrencinin adını giriniz:");
            OgrenciDelete(Console.ReadLine());
            OgrenciList();
            Console.ReadKey();
        }
        static public string OgrenciEkle(string ogrenciAd)
        {
            _ogrenciAd.Add(ogrenciAd);
            return ogrenciAd;
        }
        static public void OgrenciList()
        {
            Console.Clear();
            foreach (var ogrenci in _ogrenciAd)
            {
                Console.WriteLine(ogrenci);
            }

        }
        static public string OgrenciGuncelle(string guncellenecekisim, string guncelisim)
        {
            for (int i = 0; i < _ogrenciAd.Count; i++)
            {
                if (_ogrenciAd[i] == guncellenecekisim)
                {
                    _ogrenciAd[i] = guncelisim;
                }
                else
                {
                    Console.WriteLine("Başarısız");
                }
            }/*
            guncellenecekisim.Replace(guncellenecekisim, guncelisim);
            _ogrenciAd.Remove(guncellenecekisim);
            _ogrenciAd.Add(guncelisim);*/
            return guncelisim;
        }
        static public void OgrenciDelete(string ogrenciAd)
        {
            _ogrenciAd.Remove(ogrenciAd);
        }
    }
}
