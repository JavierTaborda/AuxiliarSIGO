using Microsoft.EntityFrameworkCore;
using AuxiliarSIGO.Models;

namespace AuxiliarSIGO.Data
{
    public class Consultas : IConsultas
    {
        private readonly SIGOContext _contex;



        //public AudiHalla(HttpClient http)
        //{
        //    this._http = http;
        //}
        public Consultas(SIGOContext contex)
        {
            _contex = contex;
        }

        public async Task<IEnumerable<MasterVariable>> GetVariables(int centro)
        {
            
            return await _contex.MasterVariables
                    .Where(a => a.CentroTrabajoId == centro)
                    .Select(a => new MasterVariable {  Id = a.Id, VariableId=a.VariableId, CalidadId = a.CalidadId, Max = a.Max, Min = a.Min, CentroTrabajoId = a.CentroTrabajoId, PuntoMuestreoId =a.PuntoMuestreoId, UnidadMedidaId=a.UnidadMedidaId })
                    //.Select(a =>a.
                    .ToListAsync();


        }
        public async Task<IEnumerable<Variable>> GetNombreVar()
        {
            return await _contex.Variables
                    .Where(a => a.AreaId == 1)//Conversion
                    .Select(a => new Variable { IdVariable =a.IdVariable, NombreVariable=a.NombreVariable})
                    .AsNoTracking() 
                    .ToListAsync();

        }
        public async Task<IEnumerable<PuntoMuestreo>> GetMuestreos(int area)
        {
            return await _contex.PuntoMuestreos
                    .Where(a => a.AreaId == area)//Conversion
                    .Select(a => new PuntoMuestreo { PuntoMuestreoId=a.PuntoMuestreoId, Descripcion=a.Descripcion})
                    .AsNoTracking()
                    .ToListAsync();

        }



        public async Task<IEnumerable<UnidadMedidum>> GetUnidades()
        {
            return await _contex.UnidadMedida.AsNoTracking().ToListAsync();
        }
        public async Task<IEnumerable<CentroTrabajo>> GetCentros(int area)
        {

            return await _contex.CentroTrabajos
                .Where(a => a.AreaId == area)
                .ToListAsync();

        }
        public async Task<IEnumerable<Calidad>> GetCalidad()
        {
            return await _contex.Calidads.AsNoTracking().ToListAsync();
        }

        public async Task<bool> UpdateMasterV(MasterVariable MasterV)
        {
           

            _contex.Entry(MasterV).Property(a => a.Min).IsModified = true;
            _contex.Entry(MasterV).Property(a => a.Max).IsModified = true;
            _contex.Entry(MasterV).Property(a => a.UnidadMedidaId).IsModified = true;

            //_contex.Entry(MasterV).State = EntityState.Modified;
            return await _contex.SaveChangesAsync() > 0;
        }

    }
}
