using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasiG048
{
    //nesnenin tanımlandığı şablon
    internal class Ogrenci
    {
        public SUBE Sube;
        public CINSIYET Cinsiyet;
        public DateTime DogumTarihi;
        public Adres Adres;
        public int No;
        public string Ad;
        public string Soyad;
        public float Ortalama;

        public List<string> Kitaplar = new List<string>();
        public List<DersNotu> Notlar = new List<DersNotu>();
        public Ogrenci(int no, string ad, string soyad, DateTime dTraihi, CINSIYET cins, SUBE sb)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.DogumTarihi = dTraihi;
            this.Cinsiyet = cins;
            this.Sube = sb;
        }
    }
    public enum SUBE
    {
        A,B,C,D
    }
    public enum CINSIYET
    {
        Kız, 
        Erkek
    }
}
