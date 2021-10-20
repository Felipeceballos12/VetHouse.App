using System.Collections.Generic;
using System.Linq;
using VetHouse.App.Dominio;

namespace VetHouse.App.Persistencia
{
    public class RepositorioCareSuggestion : IRepositorioCareSuggestion
    {
        private readonly AppVetHouseContext _appVetHouseContext = new AppVetHouseContext();

        CareSuggestion IRepositorioCareSuggestion.AddCareSuggestion(CareSuggestion careSuggestion)
        {
            var addCareSuggestion = _appVetHouseContext.CareSuggestions.Add(careSuggestion);

            _appVetHouseContext.SaveChanges();
            return addCareSuggestion.Entity;
        }

        void IRepositorioCareSuggestion.DeleteCareSuggestion(int idCareSuggestion)
        {
            var careSuggestionFound = _appVetHouseContext.CareSuggestions.FirstOrDefault(cs => cs.Id == idCareSuggestion);

            if (careSuggestionFound == null)
            {
                return;
            }

            _appVetHouseContext.CareSuggestions.Remove(careSuggestionFound);
            _appVetHouseContext.SaveChanges();
        }

        IEnumerable<CareSuggestion> IRepositorioCareSuggestion.GetAllCareSuggestion()
        {
            return _appVetHouseContext.CareSuggestions;
        }

        CareSuggestion IRepositorioCareSuggestion.UpdateCareSuggestion(CareSuggestion careSuggestion)
        {
            var careSuggestionFound = _appVetHouseContext.CareSuggestions.FirstOrDefault(cs => cs.Id == careSuggestion.Id);

            if (careSuggestionFound != null)
            {
                careSuggestionFound.Description = careSuggestion.Description;
                careSuggestionFound.CreatedAtCareSuggestion = careSuggestion.CreatedAtCareSuggestion;

                _appVetHouseContext.SaveChanges();
            }

            return careSuggestionFound;
        }

        CareSuggestion IRepositorioCareSuggestion.GetCareSuggestion(int idCareSuggestion)
        {
            return _appVetHouseContext.CareSuggestions.FirstOrDefault(cs => cs.Id == idCareSuggestion);
        }
    }
}