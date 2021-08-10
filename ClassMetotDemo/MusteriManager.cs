using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //Müşteri Listesine müşteri ekleme
        public void Add(List<Musteri> mList, Musteri m1)
        {
            mList.Add(m1);   
        }
        //Müşteri Listesini listeleme
        public void Listele(List<Musteri> mList)
        {
            foreach (var item in mList)
            {
                Console.WriteLine("Müşterinin Numarası : " + item.No);
                Console.WriteLine("Müşterinin Adı : " + item.Adi);
                Console.WriteLine("Müşterinin Soyadı : " + item.Soyadi);
                Console.WriteLine("");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
        }

        //Müşteri Listesinden müşteriyi çıkartma
        public void Sil(List<Musteri> mList, Musteri m1)
        {
            mList.Remove(m1);
        }
    }
}
