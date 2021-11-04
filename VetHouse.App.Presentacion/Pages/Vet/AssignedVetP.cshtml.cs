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
        // private readonly IRepositorioHistory _repoHistory;
        public IEnumerable<Pet> pets { get; set; }
        // public List<History> histories { get; set; }
        // public IEnumerable<Pet> getPet;
        public AssignedVetPModel(IRepositorioPet _repoPet, IRepositorioHistory _repoHistory)
        {
            this._repoPet = _repoPet;
            // this._repoHistory = _repoHistory;
        }
        public IActionResult OnGet()
        {
            // getPet = _repoVet.GetPets(1);
            pets = _repoPet.GetAllPetsOfVet(1);


            // foreach (var pet in pets)
            // {
            //     if (pet.History != null)
            //     {
            //         histories.Add(_repoHistory.GetHistory(pet.History.Id));
            //     }
            // }


            return Page();
        }
    }
}
