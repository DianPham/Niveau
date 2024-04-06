using Sales_Web.Areas.Admin.Models.Accounts;
using System.Collections.Generic;

namespace Sales_Web.Areas.Admin.Models.Repositories
{
    public interface IAccountRepository
    {
        Task<IEnumerable<ApplicationUser>> GetAllAsync();
        Task<ApplicationUser> GetByIdAsync(int id);
        Task AddAsync(ApplicationUser account);
        Task UpdateAsync(ApplicationUser account);
        Task DeleteAsync(int id);
    }
}
