using Microsoft.EntityFrameworkCore;
using SportsonView.API.Data;
using SportsonView.API.Data.Entities;
using SportsonView.API.Data.Interfaces;

namespace SportsonView.API.Repositories
{
    public class ImportantDateRepository : IImportantDateRepository
    {
        private readonly ApplicationDbContext _context;

        public ImportantDateRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ImportantDate>> GetAllImportantDatesAsync()
        {
            return await _context.ImportantDates.ToListAsync();
        }
    }
}
