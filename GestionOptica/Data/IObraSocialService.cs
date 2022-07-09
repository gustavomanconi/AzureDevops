using System.Collections.Generic;
using System.Threading.Tasks;
using GestionOptica.Models;

namespace GestionOptica.Data
{
    public interface IObraSocialService
    {
        Task<IEnumerable<ObraSocial>> GetAllObraSocial();

        Task<ObraSocial> GetObraSocialDetalle(int id);

        Task<bool> InsertObraSocial(ObraSocial obraSocial);

        Task<bool> UpdateObraSocial(ObraSocial obraSocial);

        Task<bool> DeleteObraSocial(int id);

        Task<bool> SaveObraSocial(ObraSocial obraSocial);

    }
}
