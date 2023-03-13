using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasiG048
{
    internal class DersNotu
    {
        public DERSLER Ders;
        public float Not;

        public DersNotu(DERSLER dersAdi, float dersNot)
        {
            this.Not = dersNot;
            this.Ders = dersAdi;
        }

    }
    public enum DERSLER
    {
        Empty,
        Matematik,
        Fen,
        Türkçe,
        Sosyal
    }
}
