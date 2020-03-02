using System;

namespace AgroAnaliseApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public DateTime BornDate { get; set; }
        public DateTime RegistryDate { get; set; }

        public Person() { }
         
        public Person(int id, string name, DateTime registryDate)
        {
            Id = id;
            Name = name;
            RegistryDate = registryDate;
        }

        public Person(int id, string name, DateTime bornDate, DateTime registryDate)
        {
            Id = id;
            Name = name;
            BornDate = bornDate;
            RegistryDate = registryDate;
        }
    }
}
