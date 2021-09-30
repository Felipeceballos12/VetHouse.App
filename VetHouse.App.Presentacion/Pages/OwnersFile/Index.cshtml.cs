using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetHouse.App.Dominio;
using VetHouse.App.Persistencia;

namespace VetHouse.App.Presentacion.Pages.OwnersFile
{
    public class IndexModel : PageModel
    {
        public readonly IRepositorioOwner _repoOwner;
        public IEnumerable<Owner> Owners { get; set; }

        public IndexModel(IRepositorioOwner _repoOwner)
        {
            this._repoOwner = _repoOwner;
        }
        public void OnGet()
        {
            Owners = _repoOwner.GetAllOwner();
        }
    }
}
