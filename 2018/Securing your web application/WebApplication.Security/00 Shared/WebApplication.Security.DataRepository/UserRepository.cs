using System.Collections.Generic;
using System.Linq;
using WebApplication.Security.DataRepository.Context;
using WebApplication.Security.DataRepository.Models;

namespace WebApplication.Security.DataRepository
{
	public class UserRepository
	{
		/// <summary>
		/// Return a user for the provided email and password
		/// </summary>
		/// <param name="email"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public User ForEmailAndPassword(string email, string password)
		{
			using (var context = new LobsterContext())
			{
				var user = context.User.FirstOrDefault(x => x.Email == email && x.Password == password);
				return user;
			}
		}

		/// <summary>
		/// Return all users in the system
		/// </summary>
		/// <returns></returns>
		public List<User> GetAll()
		{
			using (var context = new LobsterContext())
			{
				var users = context.User.ToList();
				return users;
			}
		}
	}
}
