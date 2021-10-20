using System.Collections.Generic;
using System.Linq;
using VetHouse.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace VetHouse.App.Persistencia
{
    public class RepositorioAuxVet : IRepositorioAuxVet
    {
        private readonly AppVetHouseContext _appVetHouseContext;

        public RepositorioAuxVet(AppVetHouseContext appVetHouseContext)
        {
            _appVetHouseContext = appVetHouseContext;
        }

        AuxVet IRepositorioAuxVet.AddAuxVet(AuxVet auxVet)
        {
            var addAuxVet = _appVetHouseContext.AuxVets.Add(auxVet);

            _appVetHouseContext.SaveChanges();
            return addAuxVet.Entity;
        }

        void IRepositorioAuxVet.DeleteAuxVet(int idAuxVet)
        {
            var auxVetFound = _appVetHouseContext.AuxVets.Find(idAuxVet);

            if (auxVetFound == null)
            {
                return;
            }

            _appVetHouseContext.AuxVets.Remove(auxVetFound);
            _appVetHouseContext.SaveChanges();
        }

        IEnumerable<AuxVet> IRepositorioAuxVet.GetAllAuxVet()
        {
            return _appVetHouseContext.AuxVets;
        }

        AuxVet IRepositorioAuxVet.UpdateAuxVet(AuxVet auxVet)
        {
            var auxVetFound = _appVetHouseContext.AuxVets.FirstOrDefault(av => av.Id == auxVet.Id);

            if (auxVetFound != null)
            {
                auxVetFound.Name = auxVet.Name;
                auxVetFound.Surname = auxVet.Surname;
                auxVetFound.PhoneNumber = auxVet.PhoneNumber;
                auxVetFound.Gender = auxVet.Gender;
                auxVetFound.Email = auxVet.Email;
                auxVetFound.ProfessionalCard = auxVet.ProfessionalCard;
                auxVetFound.LaborHours = auxVet.LaborHours;

                _appVetHouseContext.SaveChanges();
            }

            return auxVetFound;
        }

        AuxVet IRepositorioAuxVet.GetAuxVet(int idAuxVet)
        {
            return _appVetHouseContext.AuxVets.FirstOrDefault(av => av.Id == idAuxVet);
        }
    }
}