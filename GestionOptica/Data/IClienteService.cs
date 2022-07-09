using GestionOptica.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionOptica.Data
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllClientes();

        Task<Cliente> GetClienteDetalle(int id);

        Task<bool> InsertCliente(Cliente cliente);

        Task<bool> UpdateCliente(Cliente cliente);

        Task<bool> DeleteCliente(int id);

        Task<bool> SaveCliente(Cliente cliente);

    }
}
