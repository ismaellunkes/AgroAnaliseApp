using AgroAnaliseApp.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AgroAnaliseApp.Models.ViewModels
{
    public class FarmDocumentsViewModel
    {
        public int Id { get; set; }
        public Farm Farm { get; set; }
        public List<Document> Documents { get; set; }

        public FarmDocumentsViewModel() { }

        public FarmDocumentsViewModel(int id, Farm farm)
        {
            Id = id;
            Farm = farm;
        }
    }
}
