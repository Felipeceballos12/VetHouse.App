using System.Collections.Generic;
using System.Linq;
using VetHouse.App.Dominio;

namespace VetHouse.App.Persistencia
{
    public class RepositorioHistory : IRepositorioHistory
    {
        private readonly AppVetHouseContext _appVetHouseContext;

        public RepositorioHistory(AppVetHouseContext appVetHouseContext)
        {
            _appVetHouseContext = appVetHouseContext;
        }

        History IRepositorioHistory.AddHistory(History history)
        {
            var addHistory = _appVetHouseContext.Histories.Add(history);

            _appVetHouseContext.SaveChanges();
            return addHistory.Entity;
        }

        void IRepositorioHistory.DeleteHistory(int idHistory)
        {
            var historyFound = _appVetHouseContext.Histories.FirstOrDefault(h => h.Id == idHistory);

            if (historyFound == null)
            {
                return;
            }

            _appVetHouseContext.Histories.Remove(historyFound);
            _appVetHouseContext.SaveChanges();
        }

        IEnumerable<History> IRepositorioHistory.GetAllHistory()
        {
            return _appVetHouseContext.Histories;
        }

        History IRepositorioHistory.UpdateHistory(History history)
        {
            var historyFound = _appVetHouseContext.Histories.FirstOrDefault(h => h.Id == history.Id);

            if (historyFound != null)
            {
                historyFound.CreatedAtHistory = history.CreatedAtHistory;
                historyFound.Diagnose = history.Diagnose;

                _appVetHouseContext.SaveChanges();
            }

            return historyFound;
        }

        History IRepositorioHistory.GetHistory(int idHistory)
        {
            return _appVetHouseContext.Histories.FirstOrDefault(h => h.Id == idHistory);
        }

        CareSuggestion IRepositorioHistory.AddCareSuggestion(int idHistory, int idCareSuggestion)
        {
            var historyFound = _appVetHouseContext.Histories.FirstOrDefault(h => h.Id == idHistory);

            if (historyFound != null)
            {
                var careSuggestionFound = _appVetHouseContext.CareSuggestions.FirstOrDefault(cs => cs.Id == idCareSuggestion);

                if (careSuggestionFound != null)
                {
                    historyFound.CareSuggestion = careSuggestionFound;
                    _appVetHouseContext.SaveChanges();
                }

                return careSuggestionFound;
            }

            return null;
        }

        VitalSign IRepositorioHistory.AddVitalSign(int idHistory, int idVitalSign)
        {
            var historyFound = _appVetHouseContext.Histories.FirstOrDefault(h => h.Id == idHistory);

            if (historyFound != null)
            {
                var vitalSignFound = _appVetHouseContext.VitalSigns.FirstOrDefault(vs => vs.Id == idVitalSign);

                if (vitalSignFound != null)
                {
                    historyFound.VitalSign = vitalSignFound;
                    _appVetHouseContext.SaveChanges();
                }

                return vitalSignFound;
            }

            return null;
        }
    }
}