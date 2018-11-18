using System.Collections.Generic;
using WebApplication.Security.DataRepository.Models;

namespace WebApplication.Security.DataRepository
{
	public class CommentRepository
	{
		public static List<Comment> Comments { get; set; }

		/// <summary>
		/// CTOR
		/// </summary>
		static CommentRepository()
		{
			Comments = new List<Comment>();
		}

		/// <summary>
		/// Add a new comment
		/// </summary>
		public void New(Comment comment)
		{
			Comments.Add(comment);
		}

		/// <summary>
		/// Return all comments
		/// </summary>
		/// <returns></returns>
		public List<Comment> All()
		{
			return Comments;
		}
	}
}
