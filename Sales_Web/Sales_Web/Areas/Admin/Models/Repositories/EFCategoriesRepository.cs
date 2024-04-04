using Microsoft.EntityFrameworkCore;
using Sales_Web.Areas.Admin.Models.Products;
using Sales_Web.Data;

namespace Sales_Web.Areas.Admin.Models.Repositories
{
    public class EFCategoriesRepository : ICategoriesRepository
    {
        private readonly ApplicationDbContext _context;
        public EFCategoriesRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();

        }
        public async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);

        }
        public async Task AddAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

    }
}
