using Microsoft.AspNetCore.Mvc;
using WebApplication.Security.DataRepository.Models;

namespace WebApplication.Security.XSS.Controllers
{
	public class BaseController : Controller
	{
		protected User CurrentUser => new User
		{
			Id = 1,
			Email = "marjan@emitknowledge.com"
		};
	}
}
