using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasiG048
{
    //Kullanıcı etkileşimi
    static internal class Uygulama
    {
        Okul Okulumuz = new Okul();
        public void Calistir()
        {
            Okulumuz.SahteVeriGir();
            //akışı anlatacağız.
            //Menu();
            //SecimAl();
            //switch-case;
        }

        public void OgrenciEkle()
        {
            //kullanıcıdan no/ad/soyad/dtarihi... bilgilerini alacak
            //Okul sınıfındaki metota gönderecek
            int no;
            string ad;
            string soyad;
            DateTime dogumTarihi;
            SUBE sb;
            CINSIYET cinsiyet;
            //Okulumuz.OgrenciEkleme(no, ad, soyad, dogumTarihi, cinsiyet, sb);

        }



        public void NotGir()
        {
            try
            {
                Console.Write("Ögrencinin numarasi:  ");
                int no=0;

                Console.WriteLine("Ögrencinin Adı Soyadı: ");
                Console.WriteLine("Ögrencinin Subesi: ");
                Console.WriteLine();
                Console.Write("Not eklemek istediğiniz ders:  ");
                DERSLER ders = (DERSLER)Enum.Parse(typeof(DERSLER), Console.ReadLine());

                Console.Write("Eklemek istediginiz not adedi: ");
                int adet = int.Parse(Console.ReadLine());
                for (int i = 1; i <= adet; i++)
                {
                    Console.Write(i + ". Notu girin: ");
                    float not = float.Parse(Console.ReadLine());


                    Okulumuz.NotEkleme(no, ders, not);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
