using Microsoft.EntityFrameworkCore;
using SportsonView.API.Data;
using SportsonView.API.Data.Entities;
using SportsonView.API.Data.Interfaces;

namespace SportsonView.API.Data.Repositories
{
    public class ManualRepository : IManualRepository
    {
        private readonly ApplicationDbContext _context;

        public ManualRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Manual>> GetAllAsync(string? type, string? search)
        {
            var query = _context.Manuals.AsQueryable();


            if (type == "youtube")
                query = query.Where(manual => manual.Type == "youtube");

            if (type == "pdf")
                query = query.Where(manual => manual.Type == "pdf");

            if (search != null)
                query = query.Where(manual => manual.Title.Contains(search) ||
                manual.Description.Contains(search));

            return await query.ToListAsync<Manual>(); ;
        }
    }
}
