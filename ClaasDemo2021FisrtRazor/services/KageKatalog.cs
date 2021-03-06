using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClaasDemo2021FisrtRazor.model;

namespace ClaasDemo2021FisrtRazor.services
{
    public class KageKatalog: IKageKatalog
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
            get => new List<Kage>(_kager);
            
        }

        public void AddKage(Kage kage)
        {
            _kager.Add(kage);
        }

        public List<Kage> Search(string searchText)
        {
            if (String.IsNullOrWhiteSpace(searchText))
            {
                return new List<Kage>(_kager);
            }

            return _kager.FindAll(k => k.Navn.Contains(searchText));
        }

        public Kage Get(int id)
        {
            if (!_kager.Exists(k => k.Id == id))
            {
                throw new KeyNotFoundException("Id findes ikke " + id);
            }

            return _kager.Find(k => k.Id == id);
        }

        public void UpdateKage(Kage kage)
        {
            Kage foundKage = Get(kage.Id);

            foundKage.Navn = kage.Navn;
            foundKage.Pris = kage.Pris;
            foundKage.Slags = kage.Slags;


        }

        public Kage Slet(int id)
        {
            Kage foundKage = Get(id);

            _kager.Remove(foundKage);
            return foundKage;
        }
    }
}
