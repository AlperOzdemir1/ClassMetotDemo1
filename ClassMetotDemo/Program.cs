using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fonksiyonların kullanılabilmesi için tanımlamalar
            MusteriManager musteriManager = new MusteriManager();
            List<Musteri> mList = new List<Musteri>();

            //Müşteri tanımlanması ve listeye atılması
            Musteri m1 = new Musteri();
            m1.No = 1;
            m1.Adi = "Alper";
            m1.Soyadi = "Özdemir";
            musteriManager.Add(mList, m1);

            //Müşterilerin listelenmesi
            musteriManager.Listele(mList);

            Musteri m2 = new Musteri();
            m2.No = 2;
            m2.Adi = "Yusuf";
            m2.Soyadi = "Demir";
            musteriManager.Add(mList, m2);

            Musteri m3 = new Musteri();
            m3.No = 3;
            m3.Adi = "Ziya";
            m3.Soyadi = "Topçu";
            musteriManager.Add(mList, m3);

            musteriManager.Listele(mList);

            //Müşterinin listeden çıkartılması
            musteriManager.Sil(mList, m2);

            musteriManager.Listele(mList);


        }
    }
}
