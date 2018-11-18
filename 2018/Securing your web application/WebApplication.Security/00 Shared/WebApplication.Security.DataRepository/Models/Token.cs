using System;

namespace WebApplication.Security.DataRepository.Models
{
    public class Token
	{
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

	    public string Value { get; set; }

	    public DateTime ValidUntil { get; set; }

		public User AssignedWith { get; set; }
    }
}
