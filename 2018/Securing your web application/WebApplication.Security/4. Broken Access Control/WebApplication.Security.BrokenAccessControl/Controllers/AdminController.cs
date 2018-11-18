using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Security.BrokenAccessControl.Controllers
{
	public class AdminController : BaseController
	{
		[Authorize] 
		public IActionResult SystemAdministration()
		{
			// beside authorize check we need to check against the user role
			// the current logged in user should have a role admin
			return View();
		}
	}
}

