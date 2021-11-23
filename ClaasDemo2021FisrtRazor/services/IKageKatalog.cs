using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClaasDemo2021FisrtRazor.model;

namespace ClaasDemo2021FisrtRazor.services
{
    public interface IKageKatalog
    {
        List<Kage> Kager { get;  }

        void AddKage(Kage kage);
        List<Kage> Search(string searchText);

        Kage Get(int id);

        void UpdateKage(Kage kage);

        Kage Slet(int id);
    }
}
