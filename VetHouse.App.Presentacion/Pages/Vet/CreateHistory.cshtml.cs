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
    public class CreateHistoryModel : PageModel
    {
        private readonly IRepositorioHistory _repoHistory;
        private readonly IRepositorioPet _repoPet;
        public History history { get; set; }
        public Pet pet { get; set; }

        public CreateHistoryModel(IRepositorioHistory _repoHistory, IRepositorioPet _repoPet)
        {
            this._repoHistory = _repoHistory;
            this._repoPet = _repoPet;
        }
        public IActionResult OnGet(int id)
        {
            history = new History();
            pet = _repoPet.GetPet(id);

            // owner = _repoOwner.GetOwner(pet.Owner.Id);

            if (pet == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(History history, int petId)
        {
            var addHistory = _repoHistory.AddHistory(history);
            var historyId = addHistory.Id;

            var assignHistoryToPet = _repoPet.AssignHistory(petId, historyId);

            return RedirectToPage("./AssignedVetP");
        }
    }
}
