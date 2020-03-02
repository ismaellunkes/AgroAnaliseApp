
using System;
using System.Collections.Generic;

namespace AgroAnaliseApp.Models
{
    public class Farmer : Person
    {
        public List<Document> Documents { get; set; }

        public Farmer() { }

        public Farmer(int id, string name, DateTime bornDate, DateTime registryDate) : base(id, name, bornDate, registryDate)
        {
            Id = id;
            Name = name;
            BornDate = bornDate;
            RegistryDate = registryDate;
        }
    }
}
