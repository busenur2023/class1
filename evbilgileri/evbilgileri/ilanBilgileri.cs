using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evbilgileri
{
    internal class ilanBilgileri
    {
        string konum;
        string kulanimdurumu;
        string ısıtma;
        int salonsayisi;
        int çocukodasi;
        int banyosayisi;
        int binayasi;
        float fiyat;
        bool ebeveyinbanyosu;
        int katsayisi;
        bool asansör;
        bool balkonsayisi;

        public string Konum { get => konum; set => konum = value; }
        public string Kulanimdurumu { get => kulanimdurumu; set => kulanimdurumu = value; }
        public string Isıtma { get => ısıtma; set => ısıtma = value; }
        public int Salonsayisi { get => salonsayisi; set => salonsayisi = value; }
        public int Çocukodasi { get => çocukodasi; set => çocukodasi = value; }
        public int Banyosayisi { get => banyosayisi; set => banyosayisi = value; }
        public int Binayasi { get => binayasi; set => binayasi = value; }
        public float Fiyat { get => fiyat; set => fiyat = value; }
        public bool Ebeveyinbanyosu { get => ebeveyinbanyosu; set => ebeveyinbanyosu = value; }
        public int Katsayisi { get => katsayisi; set => katsayisi = value; }
        public bool Asansör { get => asansör; set => asansör = value; }
        public bool Balkonsayisi { get => balkonsayisi; set => balkonsayisi = value; }

        public ilanBilgileri(string konum, string kulanimdurumu, string ısıtma, int salonsayisi, int çocukodasi, int banyosayisi, int binayasi, float fiyat, bool ebeveyinbanyosu, int katsayisi, bool asansör, bool balkonsayisi)
        {
            Konum = konum;
            Kulanimdurumu = kulanimdurumu;
            Isıtma = ısıtma;
            Salonsayisi = salonsayisi;
            Çocukodasi = çocukodasi;
            Banyosayisi = banyosayisi;
            Binayasi = binayasi;
            Fiyat = fiyat;
            Ebeveyinbanyosu = ebeveyinbanyosu;
            Katsayisi = katsayisi;
            Asansör = asansör;
            Balkonsayisi = balkonsayisi;
        }
    }









}
