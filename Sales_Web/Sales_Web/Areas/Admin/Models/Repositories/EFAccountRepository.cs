using Microsoft.EntityFrameworkCore;
using Sales_Web.Areas.Admin.Models.Accounts;
using Sales_Web.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales_Web.Areas.Admin.Models.Repositories
{
	public class EFAccountRepository : IAccountRepository
	{
		private readonly ApplicationDbContext _context;

		public EFAccountRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<ApplicationUser>> GetAllAsync()
		{
			return await _context.Users.ToListAsync();
		}

		public async Task<ApplicationUser> GetByIdAsync(int id)
		{
			return await _context.Users.FindAsync(id);
		}

		public async Task AddAsync(ApplicationUser account)
		{
			_context.Users.Add(account);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(ApplicationUser account)
		{
			_context.Entry(account).State = EntityState.Modified;
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var account = await _context.Users.FindAsync(id);
			if (account != null)
			{
				_context.Users.Remove(account);
				await _context.SaveChangesAsync();
			}
		}
	}
}

//public async Task<IEnumerable<ApplicationUser>> GetAllAsync()
//{
//	return await _context.Users.ToListAsync();

//}
//public async Task<ApplicationUser> GetByIdAsync(int id)
//{
//	return await _context.Users.FindAsync(id);

//}
//public async Task AddAsync(ApplicationUser user)
//{
//	_context.Users.Add(user);
//	await _context.SaveChangesAsync();
//}
//public async Task UpdateAsync(ApplicationUser user)
//{
//	_context.Users.Update(user);
//	await _context.SaveChangesAsync();
//}
//public async Task DeleteAsync(int id)
//{
//	var user = await _context.Users.FindAsync(id);
//	_context.Users.Remove(user);
//	await _context.SaveChangesAsync();
//}

//public async Task<IEnumerable<ApplicationUser>> GetAllAsync()
//{
//    return await _context.Accounts.ToListAsync();
//}

//public async Task<ApplicationUser> GetByIdAsync(int id)
//{
//    return await _context.Users.FindAsync(id);
//}

//public async Task AddAsync(ApplicationUser account)
//{
//    _context.Users.Add(account);
//    await _context.SaveChangesAsync();
//}

//public async Task UpdateAsync(ApplicationUser account)
//{
//    _context.Entry(account).State = EntityState.Modified;
//    await _context.SaveChangesAsync();
//}

//public async Task DeleteAsync(ApplicationUser account)
//{
//    _context.Users.Remove(account);
//    await _context.SaveChangesAsync();
//}
