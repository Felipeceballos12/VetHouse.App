using System.Collections.Generic;
using VetHouse.App.Dominio;

namespace VetHouse.App.Persistencia
{
    public interface IRepositorioPet
    {
        IEnumerable<Pet> GetAllPet();
        Pet AddPet(Pet pet);
        Pet UpdatePet(Pet pet);
        void DeletePet(int idPet);
        Pet GetPet(int idPet);

        AuxVet AssignAuxVet(int idPet, int idAuxVet);
        Owner AssignOwner(int idPet, int idOwner);
        History AssignHistory(int idPet, int idHistory);
        Pet GetOwnerPet(int ownerId);
        Vet AssignVet(int idPet, int idVet);
        IEnumerable<Pet> GetAllPetsOfVet(int idVet);
    }
}