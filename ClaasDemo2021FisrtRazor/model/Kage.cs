using System;
using System.Collections.Generic;
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

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

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
