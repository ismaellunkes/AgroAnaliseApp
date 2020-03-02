using System;
using AgroAnaliseApp.Models.Enums;

namespace AgroAnaliseApp.Models
{
    public class Document
    {
        public int Id { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTime Validity { get; set; }
        public string DocumentLocale { get; set; }

        public Document() { }

        public Document(int id, DocumentType documentType, string name, string number)
        {
            Id = id;
            DocumentType = documentType;
            Name = name;
            Number = number;
        }

        public Document(int id, DocumentType documentType, string name, string number, DateTime validity)
        {
            Id = id;
            DocumentType = documentType;
            Name = name;
            Number = number;
            Validity = validity;
        }

        public Document(int id, DocumentType documentType, string name, string number, DateTime validity, string documentLocale)
        {
            Id = id;
            DocumentType = documentType;
            Name = name;
            Number = number;
            Validity = validity;
            DocumentLocale = documentLocale;
        }
    }
}
