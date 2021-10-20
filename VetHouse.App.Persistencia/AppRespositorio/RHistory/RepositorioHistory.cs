using System.Collections.Generic;
using System.Linq;
using VetHouse.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace VetHouse.App.Persistencia
{
    public class RepositorioHistory : IRepositorioHistory
    {
        private readonly AppVetHouseContext _appVetHouseContext = new AppVetHouseContext();

        History IRepositorioHistory.AddHistory(History history)
        {
            var addHistory = _appVetHouseContext.Histories.Add(history);

            _appVetHouseContext.SaveChanges();
            return addHistory.Entity;
        }

        void IRepositorioHistory.DeleteHistory(int idHistory)
        {
            var historyFound = _appVetHouseContext.Histories.Find(idHistory);

            if (historyFound == null)
            {
                return;
            }

            _appVetHouseContext.Histories.Remove(historyFound);
            _appVetHouseContext.SaveChanges();
        }

        IEnumerable<History> IRepositorioHistory.GetAllHistory()
        {
            var allHistories = _appVetHouseContext.Histories
                                .Include(h => h.CareSuggestions)
                                .ToList();

            return allHistories;
        }

        History IRepositorioHistory.UpdateHistory(History history)
        {
            var historyFound = _appVetHouseContext.Histories.Find(history.Id);

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
            return _appVetHouseContext.Histories.Include(history => history.VitalSigns).Include(history => history.CareSuggestions).FirstOrDefault(history => history.Id == idHistory);
        }

        CareSuggestion IRepositorioHistory.AddCareSuggestion(int idHistory, int idCareSuggestion)
        {
            var historyFound = _appVetHouseContext.Histories.Find(idHistory);
            var careSuggestionFound = _appVetHouseContext.CareSuggestions.Find(idCareSuggestion);

            if (historyFound != null)
            {
                if (historyFound.CareSuggestions != null)
                {
                    historyFound.CareSuggestions.Add(careSuggestionFound);
                }
                else
                {
                    historyFound.CareSuggestions = new List<CareSuggestion>();
                    historyFound.CareSuggestions.Add(careSuggestionFound);
                }

                var historyFound2 = _appVetHouseContext.Histories.Find(historyFound.Id);

                if (historyFound2 != null)
                {
                    historyFound2.CreatedAtHistory = historyFound.CreatedAtHistory;
                    historyFound2.Diagnose = historyFound.Diagnose;

                    _appVetHouseContext.SaveChanges();

                    return careSuggestionFound;
                }
            }

            return null;
        }


        VitalSign IRepositorioHistory.AddVitalSign(int idHistory, int idVitalSign)
        {
            var historyFound = _appVetHouseContext.Histories.Find(idHistory);
            var vitalSignFound = _appVetHouseContext.VitalSigns.Find(idVitalSign);

            if (historyFound != null)
            {
                if (historyFound.VitalSigns != null)
                {
                    historyFound.VitalSigns.Add(vitalSignFound);
                }
                else
                {
                    historyFound.VitalSigns = new List<VitalSign>();
                    historyFound.VitalSigns.Add(vitalSignFound);
                }

                var historyFound2 = _appVetHouseContext.Histories.Find(historyFound.Id);

                if (historyFound2 != null)
                {
                    historyFound2.CreatedAtHistory = historyFound.CreatedAtHistory;
                    historyFound2.Diagnose = historyFound.Diagnose;

                    _appVetHouseContext.SaveChanges();

                    return vitalSignFound;
                }
            }

            return null;
        }

    }
}