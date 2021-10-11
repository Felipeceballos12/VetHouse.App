using System.Collections.Generic;
using VetHouse.App.Dominio;

namespace VetHouse.App.Persistencia
{
    public interface IRepositorioHistory
    {
        IEnumerable<History> GetAllHistory();
        History AddHistory(History history);
        History UpdateHistory(History history);
        void DeleteHistory(int idHistory);
        History GetHistory(int idHistory);

        // CareSuggestion AddCareSuggestion(int idHistory, int idCareSuggestion);
        void AddVitalSign(int idHistory, VitalSign vitalSign);
    }
}