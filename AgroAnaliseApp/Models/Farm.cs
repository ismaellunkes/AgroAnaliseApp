using System;
using System.Collections.Generic;

namespace AgroAnaliseApp.Models
{
    public class Farm
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public List<Document> Documents { get; set; }
        public DateTime RegistryDate { get; set; }
        public Farmer Farmer { get; set; }
        public int FarmerId { get; set; }

        public Farm() { }

        public Farm(int id, Address address, DateTime registryDate)
        {
            Id = id;
            Address = address;
            RegistryDate = registryDate;
        }
        public Farm(int id, Address address, DateTime registryDate, Farmer farmer)
        {
            Id = id;
            Address = address;
            RegistryDate = registryDate;
            Farmer = farmer;
        }
    }
}
