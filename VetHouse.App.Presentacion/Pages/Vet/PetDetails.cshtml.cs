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
    public class PetDetailsModel : PageModel
    {
        private readonly IRepositorioPet _repoPet;
        private readonly IRepositorioHistory _repoHistory;
        private readonly IRepositorioOwner _repoOwner;
        // private readonly IRepositorioCareSuggestion _repoCareSuggestion;
        public Pet pet { get; set; }
        public Pet petHistory { get; set; }
        public Pet petOwner { get; set; }
        public History history { get; set; }
        public Owner owner { get; set; }
        // public CareSuggestion careSuggestion { get; set; }

        public PetDetailsModel(IRepositorioPet _repoPet, IRepositorioHistory _repoHistory, IRepositorioOwner _repoOwner) // , IRepositorioCareSuggestion _repoCareSuggestion
        {
            this._repoPet = _repoPet;
            this._repoHistory = _repoHistory;
            this._repoOwner = _repoOwner;
            // this._repoCareSuggestion = _repoCareSuggestion;
        }
        public IActionResult OnGet(int id)
        {
            pet = _repoPet.GetPet(id);
            petHistory = _repoPet.GetPetWithHistory(id);
            // history = _repoHistory.GetHistory(petHistory.History.Id);
            // Console.WriteLine(petHistory.History.VitalSigns == null);
            petOwner = _repoPet.GetPetWithOwner(id);

            // history = _repoHistory.GetHistory(pet.History.Id);

            if (pet == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }

        }
    }
}
