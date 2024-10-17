using BaseLibrary.Entities;
using BaseLibrary.Responses;
using Microsoft.EntityFrameworkCore;
using ServerLibrary.Data;
using ServerLibrary.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repositories.Implementations
{
    public class SanctionRepository(AppDbContext appDbContext):IGenericRepositoryInterface<Sanction>
    {
        public async Task<GeneralResponse> DeleteById(int id)
        {
            var item = await appDbContext.Sanctions.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if (item is null) return NotFound();

            appDbContext.Sanctions.Remove(item);
            await Commit();
            return Success();
        }

        public async Task<List<Sanction>> GetAll() => await appDbContext.Sanctions.AsNoTracking().Include(o=>o.SanctionType).ToListAsync();

        public async Task<Sanction> GetById(int id) => await appDbContext.Sanctions.FirstOrDefaultAsync(c => c.EmployeeId == id);

        public async Task<GeneralResponse> Insert(Sanction item)
        {
            appDbContext.Sanctions.Add(item);
            await Commit();
            return Success();
        }

        public async Task<GeneralResponse> Update(Sanction item)
        {
            var obj = await appDbContext.Sanctions.FirstOrDefaultAsync(n => n.EmployeeId == item.EmployeeId);
            if (obj is null) return NotFound();
            obj.SanctionType = item.SanctionType;
            obj.PunishmentDate = item.PunishmentDate;
            obj.Date = item.Date;
            obj.Punishment= item.Punishment;
            await Commit();
            return Success();
        }


        private static GeneralResponse NotFound() => new(false, "Sorry data not found");
        private static GeneralResponse Success() => new(true, "Process completed");
        private async Task Commit() => await appDbContext.SaveChangesAsync();
    }
}
