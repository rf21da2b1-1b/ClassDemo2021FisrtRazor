using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClaasDemo2021FisrtRazor.model
{
    public enum KageSlagsType { Tørkage, Flødeskumskage, Sandkage, Wienerbrød}
    public class Kage
    {
        private int _id;
        private String _navn;
        private double _pris;
        private KageSlagsType _slags;

        public Kage()
        {
        }

        public Kage(int id, string navn, double pris, KageSlagsType slags)
        {
            _id = id;
            _navn = navn;
            _pris = pris;
            _slags = slags;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        [Required (ErrorMessage = "Der skal være et navn til din kage")]
        [RegularExpression(@"[A-ZÆØÅ]\w*")] // skal starte med stort bogstav
        [StringLength(15, ErrorMessage = "En kage skal have en værdi men højst 15 tegn")]
        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        [Required]
        [Range(0, 200, ErrorMessage = "Prisen skal være mellem 0-200 kr")]
        public double Pris
        {
            get => _pris;
            set => _pris = value;
        }

        public KageSlagsType Slags
        {
            get => _slags;
            set => _slags = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Pris)}: {Pris}, {nameof(Slags)}: {Slags}";
        }
    }
}
