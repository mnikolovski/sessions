using Microsoft.AspNetCore.Mvc;
using WebApplication.Security.DataRepository;
using WebApplication.Security.DataRepository.Models;

namespace WebApplication.Security.XSS.Controllers
{
	public class CommentController : BaseController
	{
		/// <summary>
		/// Add a new comment
		/// </summary>
		/// <param name="comment"></param>
		/// <returns></returns>
		[HttpPost]
		public JsonResult New(Comment comment)
		{
			var commentRepository = new CommentRepository();
			commentRepository.New(comment);
			return Json(true);
		}
	}
}
