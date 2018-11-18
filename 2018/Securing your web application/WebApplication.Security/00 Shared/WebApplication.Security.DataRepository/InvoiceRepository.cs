using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using WebApplication.Security.DataRepository.Context;
using WebApplication.Security.DataRepository.Models;

namespace WebApplication.Security.DataRepository
{
	public class InvoiceRepository
	{
		/// <summary>
		/// Dynamic search
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public List<Invoice> All(User user)
		{
			using (var context = new LobsterContext())
			{
				var invoices = context.Invoice
					.Include(x => x.User)
					.Where(x => x.UserId == user.Id)
					.ToList();
				return invoices;
			}
		}

		/// <summary>
		/// Dynamic search
		/// </summary>
		/// <param name="user"></param>
		/// <param name="column"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public List<Invoice> Search(User user, string column, string value)
		{
			using(var context = new LobsterContext())
			{
				var invoices = context.Invoice
									  .Include(x => x.User)
									  .Where($"UserId={user.Id} AND {column} = \"{value}\"")
									  .ToList();
				return invoices;
			}
		}
	}
}
