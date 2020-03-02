using AgroAnaliseApp.Models.Enums;
using System;

namespace AgroAnaliseApp.Models
{
    public class Analysis : Document
    {
        public Farm Farm { get; set; }
        public int FarmId { get; set; }

        public Analysis()  { }

        public Analysis(int id, DocumentType documentType, string name, string number, DateTime validity, string documentLocale, Farm farm) 
            : base (id, documentType, name, number, validity, documentLocale)
        {
            Id = id;
            DocumentType = documentType;
            Name = name;
            Number = number;
            Validity = validity;
            DocumentLocale = documentLocale;
            Farm = farm;
        }
    }    
}
