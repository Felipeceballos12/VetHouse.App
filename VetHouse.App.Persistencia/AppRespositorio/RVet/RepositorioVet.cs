using System.Collections.Generic;
using System.Linq;
using VetHouse.App.Dominio;
using Microsoft.EntityFrameworkCore;

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
            return _appVetHouseContext.Vets.Include(vet => vet.Pets).ToList();
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
            return _appVetHouseContext.Vets.Include(vet => vet.Pets).FirstOrDefault(vet =>  vet.Id == idVet);
        }

        Pet IRepositorioVet.AssignPet(int idVet, int idPet)
        {
            var vetFound = _appVetHouseContext.Vets.FirstOrDefault(v => v.Id == idVet);
            var petFound = _appVetHouseContext.Pets.Find(idPet);

            if (vetFound != null)
            {
                if (vetFound.Pets != null)
                {
                    vetFound.Pets.Add(petFound);
                    _appVetHouseContext.SaveChanges();
                }
                else
                {
                    vetFound.Pets = new List<Pet>();
                    vetFound.Pets.Add(petFound);
                    _appVetHouseContext.SaveChanges();
                }

                var vetFound2 = _appVetHouseContext.Vets.Find(vetFound.Id);

                if (vetFound2 != null)
                {
                    vetFound2.Name = vetFound.Name;
                    vetFound2.Surname = vetFound.Surname;
                    vetFound2.PhoneNumber = vetFound.PhoneNumber;
                    vetFound2.Gender = vetFound.Gender;
                    vetFound2.Email = vetFound.Email;
                    vetFound2.RegisterRethus = vetFound.RegisterRethus;
                    vetFound2.Specialty = vetFound.Specialty;

                    _appVetHouseContext.SaveChanges();

                    return petFound;
                }
            }

            return null;
        }

        IEnumerable<object> IRepositorioVet.GetPets(int vetId)
        {
            var petsFound = _appVetHouseContext.Vets.AsQueryable().SelectMany(vet => vet.Pets,
                                                                (vet, pet) => new { vet, pet })
                                                                .Where(vet_x => vet_x.vet.Id == vetId)
                                                                .Select(vetAndPet => new
                                                                {
                                                                    PetName = vetAndPet.pet.Name,
                                                                    PetBreed = vetAndPet.pet.Breed,
                                                                    PetType = vetAndPet.pet.Type,
                                                                    PetWeight = vetAndPet.pet.Weight,
                                                                    PetGender = vetAndPet.pet.Gender,
                                                                    PetOwnerName = vetAndPet.pet.Owner.Name + " " + vetAndPet.pet.Owner.Surname,
                                                                    PetId = vetAndPet.pet.Id
                                                                });

            if (petsFound != null)
            {
                return petsFound;
            }
            return null;
        }
    }
}