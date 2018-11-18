using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Security.DataRepository;
using WebApplication.Security.DataRepository.Models;
using WebApplication.Security.Injection.Models;

namespace WebApplication.Security.Injection.Controllers
{
	public class HomeController : BaseController
	{
		public IActionResult Index()
		{
			var repository = new InvoiceRepository();
			var invoices = repository.All(CurrentUser);
			return View(invoices);
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
