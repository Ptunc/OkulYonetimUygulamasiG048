using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasiG048
{
    //okula ait verileri yönetmek
    internal class Okul
    {
        public List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public void SahteVeriGir()
        {
            //öğrenci tanımlanıp, listeye eklenecek
            Ogrenci o = new Ogrenci(12, "Nesrin", "Nert", new DateTime(2005, 11, 23), CINSIYET.Kız, SUBE.A);
            this.ogrenciler.Add(o);
            this.ogrenciler.Add(new Ogrenci(22, "Mert", "Nert", new DateTime(2005, 11, 23), CINSIYET.Erkek, SUBE.A));
            this.ogrenciler.Add(new Ogrenci(32, "Mert", "Nert", new DateTime(2005, 11, 23), CINSIYET.Erkek, SUBE.A));
            this.ogrenciler.Add(new Ogrenci(42, "Mert", "Nert", new DateTime(2005, 11, 23), CINSIYET.Erkek, SUBE.A));
            this.ogrenciler.Add(new Ogrenci(52, "Mert", "Nert", new DateTime(2005, 11, 23), CINSIYET.Erkek, SUBE.A));
            this.ogrenciler.Add(new Ogrenci(62, "Mert", "Nert", new DateTime(2005, 11, 23), CINSIYET.Erkek, SUBE.A));
            this.ogrenciler.Add(new Ogrenci(72, "Mert", "Nert", new DateTime(2005, 11, 23), CINSIYET.Erkek, SUBE.A));
            this.ogrenciler.Add(new Ogrenci(82, "Mert", "Nert", new DateTime(2005, 11, 23), CINSIYET.Erkek, SUBE.A));
        }
        public void OgrenciEkleme(int no, string ad, string soyad, DateTime dTraihi, CINSIYET cins, SUBE sb)
        {
            this.ogrenciler.Add(new Ogrenci(no, ad, soyad, dTraihi, cins, sb));
        }
        public void NotEkleme(int no, DERSLER dersAdi, float not)
        {
            Ogrenci o = this.ogrenciler.Where(d=>d.No==no).FirstOrDefault();
            o.Notlar.Add(new DersNotu(dersAdi,not));
            
        }

    }
}
