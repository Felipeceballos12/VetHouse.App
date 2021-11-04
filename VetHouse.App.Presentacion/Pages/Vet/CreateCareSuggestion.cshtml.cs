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
    public class CreateCareSuggestionModel : PageModel
    {
        private readonly IRepositorioPet _repoPet;
        private readonly IRepositorioCareSuggestion _repoCareSuggestion;
        private readonly IRepositorioHistory _repoHistory;
        private readonly IRepositorioVitalSign _repoVitalSign;

        public Pet pet { get; set; }
        public CareSuggestion careSuggestion { get; set; }
        public VitalSign vitalSign { get; set; }
        public History history { get; set; }

        public CreateCareSuggestionModel(IRepositorioPet _repoPet, IRepositorioCareSuggestion _repoCareSuggestion, IRepositorioHistory _repoHistory, IRepositorioVitalSign _repoVitalSign)
        {
            this._repoPet = _repoPet;
            this._repoCareSuggestion = _repoCareSuggestion;
            this._repoHistory = _repoHistory;
            this._repoVitalSign = _repoVitalSign;
        }

        public IActionResult OnGet(int id)
        {
            careSuggestion = new CareSuggestion();
            // vitalSign = _repoVitalSign.GetVitalSign(id);
            vitalSign = null;

            if (vitalSign == null)
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
