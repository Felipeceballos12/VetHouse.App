using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetHouse.App.Persistencia;
using VetHouse.App.Dominio;

namespace VetHouse.App.Presentacion.Pages
{
    public class RegisterVetModel : PageModel
    {
        public readonly IRepositorioVet _repoVet;
        public Vet newVet { get; set; }
        public RegisterVetModel(IRepositorioVet _repoVet)
        {
            this._repoVet = _repoVet;
        }

        public void OnGet()
        {
            newVet = new Vet();
        }

        public IActionResult OnPost(Vet newVet)
        {
            _repoVet.AddVet(newVet);
            return RedirectToPage("/Index");
        }


    }
}
