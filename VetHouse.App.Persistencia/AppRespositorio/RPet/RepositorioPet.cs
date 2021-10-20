using System.Collections.Generic;
using System.Linq;
using VetHouse.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace VetHouse.App.Persistencia
{
    public class RepositorioPet : IRepositorioPet
    {
        private readonly AppVetHouseContext _appVetHouseContext = new AppVetHouseContext();

        Pet IRepositorioPet.AddPet(Pet pet)
        {
            var addPet = _appVetHouseContext.Pets.Add(pet);

            _appVetHouseContext.SaveChanges();
            return addPet.Entity;
        }

        void IRepositorioPet.DeletePet(int idPet)
        {
            var petFound = _appVetHouseContext.Pets.FirstOrDefault(p => p.Id == idPet);

            if (petFound == null)
            {
                return;
            }

            _appVetHouseContext.Pets.Remove(petFound);
            _appVetHouseContext.SaveChanges();
        }

        IEnumerable<Pet> IRepositorioPet.GetAllPet()
        {
            return _appVetHouseContext.Pets;
        }

        Pet IRepositorioPet.UpdatePet(Pet pet)
        {
            var petFound = _appVetHouseContext.Pets.FirstOrDefault(p => p.Id == pet.Id);

            if (petFound != null)
            {
                petFound.Name = pet.Name;
                petFound.Type = pet.Type;
                petFound.Breed = pet.Breed;
                petFound.Address = pet.Address;
                petFound.Latitud = pet.Latitud;
                petFound.Longitude = pet.Longitude;
                petFound.Weight = pet.Weight;
                petFound.DateOfBirth = pet.DateOfBirth;
                petFound.Gender = pet.Gender;

                _appVetHouseContext.SaveChanges();
            }

            return petFound;
        }

        Pet IRepositorioPet.GetPet(int idPet)
        {
            return _appVetHouseContext.Pets.Include(pet => pet.Owner).Include(pet => pet.History).FirstOrDefault(pet => pet.Id == idPet);
        }

        AuxVet IRepositorioPet.AssignAuxVet(int idPet, int idAuxVet)
        {
            var petFound = _appVetHouseContext.Pets.FirstOrDefault(p => p.Id == idPet);

            if (petFound != null)
            {
                var auxVetFound = _appVetHouseContext.AuxVets.FirstOrDefault(av => av.Id == idAuxVet);

                if (auxVetFound != null)
                {
                    petFound.AuxVet = auxVetFound;
                    _appVetHouseContext.SaveChanges();
                }

                return auxVetFound;
            }

            return null;
        }

        Owner IRepositorioPet.AssignOwner(int idPet, int idOwner)
        {
            var petFound = _appVetHouseContext.Pets.FirstOrDefault(p => p.Id == idPet);

            if (petFound != null)
            {
                var ownerFound = _appVetHouseContext.Owners.FirstOrDefault(o => o.Id == idOwner);

                if (ownerFound != null)
                {
                    petFound.Owner = ownerFound;
                    _appVetHouseContext.SaveChanges();
                }

                return ownerFound;
            }

            return null;
        }


        Vet IRepositorioPet.AssignVet(int idPet, int idvet)
        {
            var petFound = _appVetHouseContext.Pets.FirstOrDefault(p => p.Id == idPet);

            if (petFound != null)
            {
                var vetFound = _appVetHouseContext.Vets.FirstOrDefault(vet => vet.Id == idvet);

                if (vetFound != null)
                {
                    petFound.idVet = vetFound.Id;
                    petFound.Vet = vetFound;
                    _appVetHouseContext.SaveChanges();
                }

                return vetFound;
            }

            return null;
        }

        History IRepositorioPet.AssignHistory(int idPet, int idHistory)
        {
            var petFound = _appVetHouseContext.Pets.FirstOrDefault(p => p.Id == idPet);

            if (petFound != null)
            {
                var historyFound = _appVetHouseContext.Histories.FirstOrDefault(h => h.Id == idHistory);

                if (historyFound != null)
                {
                    petFound.History = historyFound;
                    _appVetHouseContext.SaveChanges();
                }

                return historyFound;
            }

            return null;
        }


        Pet IRepositorioPet.GetOwnerPet(int ownerId)
        {
            var petFound = _appVetHouseContext.Pets.Where(pet => pet.Owner.Id == ownerId).FirstOrDefault();

            if (petFound != null)
            {
                return petFound;
            }

            return null;
        }

        IEnumerable<Pet> IRepositorioPet.GetAllPetsOfVet(int idVet)
        {
            var petsFound = _appVetHouseContext.Pets.Include(pet => pet.Owner).Where(pet => pet.idVet == idVet).ToList();

            if (petsFound != null)
            {
                return petsFound;
            }

            return null;
        }


        // IEnumerable<Pet> IRepositorioPet.GetVetPets(int vetId)
        // {
        //     var petsFound = _appVetHouseContext.Pets.Where(pet => pet.idVet == vetId).FirstOrDefault();
        // }

    }
}