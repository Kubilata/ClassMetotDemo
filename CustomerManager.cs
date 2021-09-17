using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void Ekle(Customer musteriler)

        {
            Console.WriteLine("Müşteri Ekleme İşlemi Başarılı Bir Şekilde Gerçekleştirildi!");
            Console.WriteLine("Müşteri Adı : " + musteriler.Ad);
            Console.WriteLine("Müşteri Soyadı : " + musteriler.Soyad);
            Console.WriteLine("Müşteri Yaşı : " + musteriler.Yas);
            Console.WriteLine("Müşteri Telefonu : " + musteriler.TelefonNumarasi);
            Console.WriteLine("Müşteri Kimliği : " + musteriler.TcKimlikNo);
        }

        public void Sil(Customer musteriler)
        {
            Console.WriteLine("Müşteri Silme İşlemi Başarılı Bir Şekilde Gerçekleştirildi!");
            Console.WriteLine("Silinen Müşteri Hesap No'su : " + musteriler.Id);
            Console.WriteLine("Silinen Müşteri Hesap Adı : " + musteriler.Ad + musteriler.Soyad);
        }

        public void Listele(Customer  musteriler)
        {
            Console.WriteLine(musteriler.Id + ", " + musteriler.Ad + ", " + musteriler.Soyad + ", " + musteriler.Yas);
        }


    }
}