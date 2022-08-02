using Microsoft.EntityFrameworkCore;
using AuxiliarSIGO.Models;
namespace AuxiliarSIGO.Data
{
    public interface IConsultas
    {
        Task<IEnumerable<MasterVariable>> GetVariables(int centro);
        Task<bool> UpdateMasterV(MasterVariable MasterV);
        Task<IEnumerable<PuntoMuestreo>> GetMuestreos(int area);
        Task<IEnumerable<Variable>> GetNombreVar();

        Task<IEnumerable<CentroTrabajo>> GetCentros(int Area);
        Task<IEnumerable<UnidadMedidum>> GetUnidades();
        Task<IEnumerable<Calidad>> GetCalidad();

  

    }
}
