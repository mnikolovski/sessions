using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Security.DataRepository;
using WebApplication.Security.DataRepository.Models;

namespace WebApplication.Security.SensitiveDataExposure.Controllers
{
	public class InvoiceController : BaseController
	{
		[HttpGet]
		public JsonResult All()
		{
			var repository = new InvoiceRepository();
			var invoices = repository.All(CurrentUser);
			return Json(invoices);
		}
	}
}
