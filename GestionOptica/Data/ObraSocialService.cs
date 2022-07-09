using GestionOptica.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionOptica.Data
{
    public class ObraSocialService : IObraSocialService
    {
        private readonly MyClientesContext db;

        public ObraSocialService(MyClientesContext context)
        {
            db = context;
        }
        public async Task<bool> DeleteObraSocial(int id)
        {
            var obrasocial = await db.ObraSocial.FindAsync(id);
            db.ObraSocial.Remove(obrasocial);
            return await db.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<ObraSocial>> GetAllObraSocial()
        {
            return await db.ObraSocial.ToListAsync();
        }

        public async Task<ObraSocial> GetObraSocialDetalle(int id)
        {
            return await db.ObraSocial.FindAsync(id);
        }

        public async Task<bool> InsertObraSocial(ObraSocial obrasocial)
        {
            db.ObraSocial.Add(obrasocial);
            return await db.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveObraSocial(ObraSocial obrasocial)
        {
            if (obrasocial.ObraSocialId > 0)
            {
                return await UpdateObraSocial(obrasocial);
            }
            else
            {
                return await InsertObraSocial(obrasocial);
            }
        }

        public async Task<bool> UpdateObraSocial(ObraSocial obrasocial)
        {
            db.Entry(obrasocial).State = EntityState.Modified;
            return await db.SaveChangesAsync() > 0;
        }
    }
}

