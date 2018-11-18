using Microsoft.AspNetCore.Mvc;
using WebApplication.Security.DataRepository.Models;

namespace WebApplication.Security.Injection.Controllers
{
	public class BaseController : Controller
	{
		protected User CurrentUser => new User
		{
			Id = 2,
			Email = "marjan@emitknowledge.com"
		};
	}
}
