using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Security.DataRepository;
using WebApplication.Security.DataRepository.Models;
using WebApplication.Security.SensitiveDataExposure.Models;

namespace WebApplication.Security.SensitiveDataExposure.Controllers
{
	public class HomeController : BaseController
	{
		public IActionResult Index()
		{
			return View(new List<Invoice>());
		}

		public IActionResult Search(string column, string value)
		{
			var repository = new InvoiceRepository();
			var invoices = repository.Search(CurrentUser, column, value);
			return View("Index", invoices);
		}
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
