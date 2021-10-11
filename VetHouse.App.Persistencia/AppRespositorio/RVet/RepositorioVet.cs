using System.Collections.Generic;
using System.Linq;
using VetHouse.App.Dominio;

namespace VetHouse.App.Persistencia
{
    public class RepositorioVet : IRepositorioVet
    {
        private readonly AppVetHouseContext _appVetHouseContext = new AppVetHouseContext();

        Vet IRepositorioVet.AddVet(Vet vet)
        {
            var addVet = _appVetHouseContext.Vets.Add(vet);

            _appVetHouseContext.SaveChanges();
            return addVet.Entity;
        }

        void IRepositorioVet.DeleteVet(int idVet)
        {
            var vetFound = _appVetHouseContext.Vets.FirstOrDefault(v => v.Id == idVet);

            if (vetFound == null)
            {
                return;
            }

            _appVetHouseContext.Vets.Remove(vetFound);
            _appVetHouseContext.SaveChanges();
        }

        IEnumerable<Vet> IRepositorioVet.GetAllVet()
        {
            return _appVetHouseContext.Vets;
        }

        Vet IRepositorioVet.UpdateVet(Vet vet)
        {
            var vetFound = _appVetHouseContext.Vets.FirstOrDefault(v => v.Id == vet.Id);

            if (vetFound != null)
            {
                vetFound.Name = vet.Name;
                vetFound.Surname = vet.Surname;
                vetFound.PhoneNumber = vet.PhoneNumber;
                vetFound.Gender = vet.Gender;
                vetFound.Email = vet.Email;
                vetFound.RegisterRethus = vet.RegisterRethus;
                vetFound.Specialty = vet.Specialty;

                _appVetHouseContext.SaveChanges();
            }

            return vetFound;
        }

        Vet IRepositorioVet.GetVet(int idVet)
        {
            return _appVetHouseContext.Vets.FirstOrDefault(v => v.Id == idVet);
        }
    }
}