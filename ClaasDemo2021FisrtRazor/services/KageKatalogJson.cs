using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ClaasDemo2021FisrtRazor.model;

namespace ClaasDemo2021FisrtRazor.services
{
    public class KageKatalogJson:IKageKatalog
    {
        private string _filename = @"data\KagerJson.json";
        public List<Kage> Kager { get; private set; }


        public KageKatalogJson()
        {
            try
            {
                using (var file = File.OpenText(_filename))
                {
                    Kager = JsonSerializer.Deserialize<List<Kage>>(file.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Kager = new List<Kage>();
            }
        }


        public void AddKage(Kage kage)
        {
            Kager.Add(kage);
            StoreToJson();
        }

        

        public List<Kage> Search(string searchText)
        {
            if (String.IsNullOrWhiteSpace(searchText))
            {
                return new List<Kage>(Kager);
            }

            return Kager.FindAll(k => k.Navn.Contains(searchText));
        }

        public Kage Get(int id)
        {
            if (!Kager.Exists(k => k.Id == id))
            {
                throw new KeyNotFoundException("Id findes ikke " + id);
            }

            return Kager.Find(k => k.Id == id);
        }

        public void UpdateKage(Kage kage)
        {
            Kage foundKage = Get(kage.Id);

            foundKage.Navn = kage.Navn;
            foundKage.Pris = kage.Pris;
            foundKage.Slags = kage.Slags;

            StoreToJson();
        }

        public Kage Slet(int id)
        {
            Kage foundKage = Get(id);

            Kager.Remove(foundKage);
            StoreToJson();

            return foundKage;
        }

        private void StoreToJson()
        {
            using (var file = File.OpenWrite(_filename))
            {
                var writer = new Utf8JsonWriter(file, new JsonWriterOptions());
                JsonSerializer.Serialize(writer, Kager);
            }

        }
    }
}
