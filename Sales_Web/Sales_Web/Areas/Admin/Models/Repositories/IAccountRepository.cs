using Sales_Web.Areas.Admin.Models.Accounts;
using System.Collections.Generic;

namespace Sales_Web.Areas.Admin.Models.Repositories
{
    public interface IAccountRepository
    {
        IEnumerable<ApplicationUser> GetAll();
		ApplicationUser GetById(int id);
        void Add(ApplicationUser account);
        void Update(ApplicationUser account);
        void Delete(ApplicationUser account);
    }
}
