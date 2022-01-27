using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer kullanici1 = new Customer();
            kullanici1.Id = 1;
            kullanici1.Name  = " Kubilay";
            kullanici1.Surname = "Uçan";
            kullanici1.Age = "22";
            kullanici1.PhoneNumber = 5398148990;
            kullanici1.IdentityNumber = 54543441106;

            Customer kullanici2 = new Customer();
            kullanici2 = new Customer();
            kullanici2.Id = 2;
            kullanici2.Name = "Canberk";
            kullanici2.Surname = "Ekinci";
            kullanici2.Age = "18";
            kullanici2.PhoneNumber = 5354121845;
            kullanici2.IdentityNumber = 47516257789;

            Customer [] kullanicilar = new Customer[] { kullanici1, kullanici2 };

           CustomerManager musteriManager = new CustomerManager();
            Console.WriteLine("Müşteri Ekleme : ");
            Console.WriteLine(" ");
            musteriManager.Ekle(kullanici1);
            Console.WriteLine(" ");
            musteriManager.Ekle(kullanici2);
            Console.WriteLine(" ");

            Console.WriteLine("Müşteri Silme : ");
            Console.WriteLine(" ");
            musteriManager.Sil(kullanici1);
            Console.WriteLine(" ");
            musteriManager.Sil(kullanici2);
            Console.WriteLine(" ");

            Console.WriteLine("Müşteri Listeleme : ");
            Console.WriteLine(" ");
            musteriManager.Listele(kullanici1);
            Console.WriteLine(" ");
            musteriManager.Listele(kullanici2);
            Console.WriteLine(" ");
        }

    }
}