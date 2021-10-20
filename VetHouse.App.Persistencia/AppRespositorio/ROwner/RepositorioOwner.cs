using System.Collections.Generic;
using System.Linq;
using VetHouse.App.Dominio;

namespace VetHouse.App.Persistencia
{
    public class RepositorioOwner : IRepositorioOwner
    {
        private readonly AppVetHouseContext _appVetHouseContext = new AppVetHouseContext();

        Owner IRepositorioOwner.AddOwner(Owner owner)
        {
            var addOwner = _appVetHouseContext.Owners.Add(owner);

            _appVetHouseContext.SaveChanges();
            return addOwner.Entity;
        }

        void IRepositorioOwner.DeleteOwner(int idOwner)
        {
            var ownerFound = _appVetHouseContext.Owners.FirstOrDefault(o => o.Id == idOwner);

            if (ownerFound == null)
            {
                return;
            }

            _appVetHouseContext.Owners.Remove(ownerFound);
            _appVetHouseContext.SaveChanges();
        }

        IEnumerable<Owner> IRepositorioOwner.GetAllOwner()
        {
            return _appVetHouseContext.Owners;
        }

        Owner IRepositorioOwner.UpdateOwner(Owner owner)
        {
            var ownerFound = _appVetHouseContext.Owners.FirstOrDefault(o => o.Id == owner.Id);

            if (ownerFound != null)
            {
                ownerFound.Name = owner.Name;
                ownerFound.Surname = owner.Surname;
                ownerFound.PhoneNumber = owner.PhoneNumber;
                ownerFound.Gender = owner.Gender;
                ownerFound.Email = owner.Email;

                _appVetHouseContext.SaveChanges();
            }

            return ownerFound;
        }

        Owner IRepositorioOwner.GetOwner(int idOwner)
        {
            return _appVetHouseContext.Owners.FirstOrDefault(o => o.Id == idOwner);
        }
    }
}