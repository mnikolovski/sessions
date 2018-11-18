using Microsoft.AspNetCore.Mvc;
using WebApplication.Security.DataRepository.Models;

namespace WebApplication.Security.SensitiveDataExposure.Controllers
{
	public class BaseApiController : ControllerBase
	{
		protected User CurrentUser => new User
		{
			Id = 1,
			Email = "marjan@emitknowledge.com"
		};
	}
}
