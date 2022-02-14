using System;

namespace GelirGider
{
    public  class dbAlacak
    {
        public int Id { get; set; }
        public string Kimden { get; set; }
        public double Tutar { get; set; }
        public DateTime OdemeTarih { get; set; }
        public DateTime Tarih { get; set; }
        public string AlacakTuru { get; set; }
        public string Aciklama { get; set; }
    }
}
