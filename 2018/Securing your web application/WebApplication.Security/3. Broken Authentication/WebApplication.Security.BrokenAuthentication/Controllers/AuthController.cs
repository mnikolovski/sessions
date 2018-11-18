using Microsoft.AspNetCore.Mvc;
using WebApplication.Security.DataRepository;
using WebApplication.Security.DataRepository.Models;

namespace WebApplication.Security.BrokenAuthentication.Controllers
{
	public class AuthController : BaseController
	{
		public JsonResult RequestPasswordReset(string email)
		{
			var repository = new TokenRepository();
			var token = repository.New(new User
			{
				Email = email
			});
			return Json(token);
		}

		public IActionResult ConfirmPasswordReset(string token)
		{
			var repository = new TokenRepository();
			var existingToken = repository.All(token);
			return View("Index", existingToken);
		}
	}
}
