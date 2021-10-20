using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetHouse.App.Dominio;
using VetHouse.App.Persistencia;

namespace VetHouse.App.Presentacion.Pages.Register.Register
{
    public class RegisterPetAndOwnerModel : PageModel
    {
        public readonly IRepositorioPet _repoPet;
        public readonly IRepositorioOwner _repoOwner;
        public readonly IRepositorioVet _repoVet;
        public Pet newPet { get; set; }
        public Owner newOwner { get; set; }
        public IEnumerable<Vet> vets { get; set; }
        
        public RegisterPetAndOwnerModel(IRepositorioPet _repoPet, IRepositorioOwner _repoOwner, IRepositorioVet _repoVet)
        {
            this._repoPet = _repoPet;
            this._repoOwner = _repoOwner;
            this._repoVet = _repoVet;
        }
        public void OnGet()
        {
            vets = _repoVet.GetAllVet();
            newOwner = new Owner();
            newPet = new Pet();
        }

        public IActionResult OnPost(Pet newPet, Owner newOwner, int idVet)
        {

            var getPet = _repoPet.AddPet(newPet);
            var petId = getPet.Id;

            var getOwner = _repoOwner.AddOwner(newOwner);
            var ownerId = getOwner.Id;

            var ownerAssigned = _repoPet.AssignOwner(petId, ownerId);
            var petAssigned = _repoVet.AssignPet(idVet, petId);

            var getVet = _repoPet.AssignVet(petId, idVet);

            return RedirectToPage("/Index");
        }
    }
}
