// See https://aka.ms/new-console-template for more information

using ClassMetotDemo;




  Musteri musteri1=new Musteri();
  musteri1.Id= 001;
  musteri1.Ad="Ali";
  musteri1.Soyad="Sarilar";
  musteri1.Maas=2500;

  Musteri musteri2=new Musteri();
  musteri2.Id = 002;
  musteri2.Ad= "Gökhan";
  musteri2.Soyad= "Akg";
  musteri2.Maas=3500;

  Musteri musteri3=new Musteri();;
  musteri3.Id=003;
  musteri3.Ad="Büşra";
  musteri3.Soyad="Gms";
  musteri3.Maas=4500;

  MusteriManager musteriManager=new MusteriManager();
  musteriManager.Ekle(musteri1);
  musteriManager.Ekle(musteri2); 
  musteriManager.Ekle(musteri3);

  musteriManager.Listele(musteri1);
  musteriManager.Listele(musteri2);
  musteriManager.Listele(musteri3);


  Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

  foreach (Musteri mliste in musteriler)
  {
      Console.WriteLine("Müşteri Id : " + mliste.Id);
      Console.WriteLine("Müşteri Adı: " + mliste.Ad);
      Console.WriteLine("Müşteri Soyadı: " + mliste.Soyad);
      Console.WriteLine("Müşteri Maas: " + mliste.Maas);
  }


  