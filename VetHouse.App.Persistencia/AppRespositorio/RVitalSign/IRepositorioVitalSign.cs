using System.Collections.Generic;
using VetHouse.App.Dominio;

namespace VetHouse.App.Persistencia
{
    public interface IRepositorioVitalSign
    {
        IEnumerable<VitalSign> GetAllVitalSign();
        VitalSign AddVitalSign(VitalSign vet);
        VitalSign UpdateVitalSign(VitalSign vet);
        void DeleteVitalSign(int idVitalSign);
        VitalSign GetVitalSign(int idVitalSign);
    }
}