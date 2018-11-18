using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Security.DataRepository.Models;

namespace WebApplication.Security.DataRepository
{
	public class TokenRepository
	{
		public static List<Token> Tokens { get; set; }

		/// <summary>
		/// CTOR
		/// </summary>
		static TokenRepository()
		{
			Tokens = new List<Token>();
		}

		/// <summary>
		/// Return the token details for the provided user
		/// </summary>
		/// <returns></returns>
		public Token New(User user)
		{
			var token = new Token
			{
				AssignedWith = user,
				Value = "123456",
				ValidUntil = DateTime.Now.AddDays(1)
			};
			Tokens.Add(token);
			return token;
		}

		/// <summary>
		/// Return the token details for the provided user
		/// </summary>
		/// <param name="token"></param>
		/// <returns></returns>
		public Token All(string token)
		{
			return Tokens.FirstOrDefault(x => x.Value == token && x.ValidUntil >= DateTime.Now);
		}
	}
}
