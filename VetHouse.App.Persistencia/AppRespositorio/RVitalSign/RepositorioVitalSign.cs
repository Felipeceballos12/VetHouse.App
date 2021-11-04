using System.Collections.Generic;
using System.Linq;
using VetHouse.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace VetHouse.App.Persistencia
{
    public class RepositorioVitalSign : IRepositorioVitalSign
    {
        private readonly AppVetHouseContext _appVetHouseContext = new AppVetHouseContext();

        // public RepositorioVitalSign(AppVetHouseContext appVetHouseContext)
        // {
        //     _appVetHouseContext = appVetHouseContext;
        // }

        VitalSign IRepositorioVitalSign.AddVitalSign(VitalSign vitalSign)
        {
            var addVitalSign = _appVetHouseContext.VitalSigns.Add(vitalSign);

            _appVetHouseContext.SaveChanges();
            return addVitalSign.Entity;
        }

        void IRepositorioVitalSign.DeleteVitalSign(int idVitalSign)
        {
            var vitalSignFound = _appVetHouseContext.VitalSigns.FirstOrDefault(vs => vs.Id == idVitalSign);

            if (vitalSignFound == null)
            {
                return;
            }

            _appVetHouseContext.VitalSigns.Remove(vitalSignFound);
            _appVetHouseContext.SaveChanges();
        }

        IEnumerable<VitalSign> IRepositorioVitalSign.GetAllVitalSign()
        {
            return _appVetHouseContext.VitalSigns;
        }

        VitalSign IRepositorioVitalSign.UpdateVitalSign(VitalSign vitalSign)
        {
            var vitalSignFound = _appVetHouseContext.VitalSigns.FirstOrDefault(vs => vs.Id == vitalSign.Id);

            if (vitalSignFound != null)
            {
                vitalSignFound.HeartRate = vitalSign.HeartRate;
                vitalSignFound.BreathingFreq = vitalSign.BreathingFreq;
                vitalSignFound.Temperature = vitalSign.Temperature;
                vitalSignFound.HealthStatus = vitalSign.HealthStatus;

                _appVetHouseContext.SaveChanges();
            }

            return vitalSignFound;
        }

        VitalSign IRepositorioVitalSign.GetVitalSign(int idVitalSign)
        {
            return _appVetHouseContext.VitalSigns.Include(vs => vs.History).FirstOrDefault(vs => vs.Id == idVitalSign);
        }


        // VitalSign IRepositorioVitalSign.AssignHistory(int idVitalSign, int idHistory)
        // {
        //     var vitalSignFound = _appVetHouseContext.VitalSigns.FirstOrDefault(vs => vs.Id == idVitalSign);
        //     var historyFound = _appVetHouseContext.Histories.FirstOrDefault(h => h.Id == idHistory);

        //     if (vitalSignFound != null)
        //     {
        //         if (vitalSignFound.idHistory != null)
        //         {
        //             if (historyFound != null)
        //             {
        //                 vitalSignFound.idHistory = historyFound.Id;
        //                 vitalSignFound.History = historyFound;
        //                 _appVetHouseContext.SaveChanges();

        //                 return vitalSignFound;
        //             }
        //         }
        //     }

        //     return null;
        // }
    }
}