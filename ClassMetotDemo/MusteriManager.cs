using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müsteri Eklendi : " + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Maas);

        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listele : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.Clear();
            Console.WriteLine("Belirtilen bilgilerdeki müşteri silindi!. - " + musteri.Id + " "  + musteri.Ad + " " + musteri.Soyad + " " + musteri.Maas );
        }
    }
}
