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
    public class AddVitalSignModel : PageModel
    {
        private readonly IRepositorioVitalSign _repoVitalSign;
        private readonly IRepositorioHistory _repoHistory;
        private readonly IRepositorioPet _repoPet;
        
        public VitalSign newVitalSign { get; set; }
        public Pet pet { get; set; }

        public AddVitalSignModel(IRepositorioVitalSign _repoVitalSign, IRepositorioPet _repoPet, IRepositorioHistory _repoHistory) //, IRepositorioOwner _repoOwner
        {
            this._repoVitalSign = _repoVitalSign;
            this._repoHistory = _repoHistory;
            this._repoPet = _repoPet;
        }
        public void OnGet()
        {
            pet = _repoPet.GetOwnerPet(5);
            newVitalSign = new VitalSign();
        }

        public IActionResult OnPost(int idPet, VitalSign newVitalSign)
        {
            var getVitalSign = _repoVitalSign.AddVitalSign(newVitalSign);
            var idVitalSign = getVitalSign.Id;

            var getPet = _repoPet.GetPet(idPet);
            var idHistory = getPet.History.Id;

            var getHistory = _repoHistory.AddVitalSign(idHistory, idVitalSign);

            return RedirectToPage("/Index");
        }
    }
}
