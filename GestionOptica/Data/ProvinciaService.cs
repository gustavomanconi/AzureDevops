using GestionOptica.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionOptica.Data
{
    public class ProvinciaService : IProvinciaService
    {
        private readonly MyClientesContext db;

        public ProvinciaService(MyClientesContext context)
        {
            db = context;
        }
        public async Task<bool> Delete(int id)
        {
            var provincia = await db.Provincia.FindAsync(id);
            db.Provincia.Remove(provincia);
            return await db.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Provincia>> GetAll()
        {
            return await db.Provincia.ToListAsync();
        }

        public async Task<Provincia> GetDetalle(int id)
        {
            return await db.Provincia.FindAsync(id);
        }

        public async Task<bool> Insert(Provincia provincia)
        {
            db.Provincia.Add(provincia);
            return await db.SaveChangesAsync() > 0;
        }

        public async Task<bool> Save(Provincia provincia)
        {
            if (provincia.ProvinciaId > 0)
            {
                return await Update(provincia);
            }
            else
            {
                return await Insert(provincia);
            }
        }
    
        public async Task<bool> Update(Provincia provincia)
        {
            db.Entry(provincia).State = EntityState.Modified;
            return await db.SaveChangesAsync() > 0;
        }
    }
}
