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
    }
}