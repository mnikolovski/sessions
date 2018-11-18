using Microsoft.AspNetCore.Mvc;
using WebApplication.Security.DataRepository;

namespace WebApplication.Security.XSS.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var commentRepository = new CommentRepository();
			var comments = commentRepository.All();
			return View(comments);
		}
	}
}
