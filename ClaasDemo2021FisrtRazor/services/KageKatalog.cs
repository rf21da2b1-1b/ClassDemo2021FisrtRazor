using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClaasDemo2021FisrtRazor.model;

namespace ClaasDemo2021FisrtRazor.services
{
    public class KageKatalog
    {
        private List<Kage> _kager = null;

        public KageKatalog()
        {
            if (_kager == null)
            {
                _kager = new List<Kage>();
                _kager.Add(new Kage(3, "kaj", 23, KageSlagsType.Flødeskumskage));
                _kager.Add(new Kage(4, "drømemkage", 45, KageSlagsType.Sandkage));
                _kager.Add(new Kage(5, "Snegl", 16, KageSlagsType.Wienerbrød));
                _kager.Add(new Kage(6, "Vaffel", 24, KageSlagsType.Tørkage));
            }
        }

        public List<Kage> Kager
        {
            get => _kager;
            
        }
    }
}
