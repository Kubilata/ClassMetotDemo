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
            Console.WriteLine("Müşteri Adı : " + musteriler.Name);
            Console.WriteLine("Müşteri Soyadı : " + musteriler.Surname);
            Console.WriteLine("Müşteri Yaşı : " + musteriler.Age);
            Console.WriteLine("Müşteri Telefonu : " + musteriler.PhoneNumber);
            Console.WriteLine("Müşteri Kimliği : " + musteriler.IdentityNumber);
        }

        public void Sil(Customer musteriler)
        {
            Console.WriteLine("Müşteri Silme İşlemi Başarılı Bir Şekilde Gerçekleştirildi!");
            Console.WriteLine("Silinen Müşteri Hesap No'su : " + musteriler.Id);
            Console.WriteLine("Silinen Müşteri Hesap Adı : " + musteriler.Name + musteriler.Surname);
        }

        public void Listele(Customer  musteriler)
        {
            Console.WriteLine(musteriler.Id + ", " + musteriler.Name + ", " + musteriler.Surname + ", " + musteriler.Age);
        }


    }
}