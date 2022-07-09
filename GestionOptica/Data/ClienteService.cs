using GestionOptica.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionOptica.Data
{
    public class ClienteService : IClienteService
    {
        private readonly MyClientesContext db;

        public ClienteService(MyClientesContext context)
        {
            db = context;
        }
        public async Task<bool> DeleteCliente(int id)
        {
            var cliente = await db.Cliente.FindAsync(id);
            db.Cliente.Remove(cliente);
            return await db.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Cliente>> GetAllClientes()
        {
            return await db.Cliente.ToListAsync();
        }

        public async Task<Cliente> GetClienteDetalle(int id)
        {
            return await db.Cliente.FindAsync(id);
        }

        public async Task<bool> InsertCliente(Cliente cliente)
        {
            db.Cliente.Add(cliente);
            return await db.SaveChangesAsync() > 0;
        }
 
        public async Task<bool> SaveCliente(Cliente cliente)
        {
            if (cliente.ClienteId > 0)
            {
                return await UpdateCliente(cliente);
            }
            else
            {
                return await InsertCliente(cliente);
            }
        }
 
        public async Task<bool> UpdateCliente(Cliente cliente)
        {
            db.Entry(cliente).State = EntityState.Modified;
            return await db.SaveChangesAsync() > 0;
        }

     
    }
}

