using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sales_Web.Areas.Admin.Models.Accounts;
using Sales_Web.Areas.Admin.Models.Repositories;
using System.Security.Principal;

namespace Sales_Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly IAccountRepository _repository;

        public AccountController(IAccountRepository repository)
        {
            _repository = repository;
        }

        // GET: Account
        public IActionResult Index()
        {
            var accounts = _repository.GetAll();
            return View(accounts);
        }

        // GET: Account/Details/5
        public IActionResult Details(int id)
        {
            var account = _repository.GetById(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // GET: Account/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationUser account)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(account);
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

		// GET: Account/Edit/5
		public IActionResult Edit(int id)
		{
			var account = _repository.GetById(id);
			if (account == null)
			{
				return NotFound();
			}
			return View(account);
		}

		// POST: Account/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(string id, ApplicationUser account) // Chuyển id thành string
		{
			if (id != account.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				_repository.Update(account);
				return RedirectToAction(nameof(Index));
			}
			return View(account);
		}

		// GET: Account/Delete/5
		public IActionResult Delete(int id)
        {
            var account = _repository.GetById(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var account = _repository.GetById(id);
            if (account == null)
            {
                return NotFound();
            }
            _repository.Delete(account);
            return RedirectToAction(nameof(Index));
        }
    }
}
