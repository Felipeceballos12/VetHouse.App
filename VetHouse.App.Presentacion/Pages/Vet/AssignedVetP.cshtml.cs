using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetHouse.App.Dominio;
using VetHouse.App.Persistencia;

namespace VetHouse.App.Presentacion.Pages
{
    public class AssignedVetPModel : PageModel
    {
        private readonly IRepositorioPet _repoPet;
        public IEnumerable<Pet> pets { get; set; }
        // public IEnumerable<Pet> getPet;
        public AssignedVetPModel(IRepositorioPet _repoPet)
        {
            this._repoPet = _repoPet;
        }
        public IActionResult OnGet()
        {
            // getPet = _repoVet.GetPets(1);
            pets = _repoPet.GetAllPetsOfVet(1);
            
            return Page();
        }
    }
}
