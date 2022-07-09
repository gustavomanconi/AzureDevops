using System.Collections.Generic;
using System.Threading.Tasks;
using GestionOptica.Models;

namespace GestionOptica.Data
{
    public interface IProvinciaService
    {
        Task<IEnumerable<Provincia>> GetAll();

        Task<Provincia> GetDetalle(int id);

        Task<bool> Insert(Provincia provincia);

        Task<bool> Update(Provincia provincia);

        Task<bool> Delete(int id);

        Task<bool> Save(Provincia provincia);
    }
}
