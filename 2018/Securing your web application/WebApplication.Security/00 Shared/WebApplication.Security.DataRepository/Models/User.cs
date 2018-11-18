using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Security.DataRepository.Models
{
    public class User
    {
        public User()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

	    public string Username { get; set; }

	    public string Password { get; set; }

	    public string PasswordSalt { get; set; }

		[NotMapped]
	    public string Token { get; set; }

		public string Email { get; set; }

	    public string Name { get; set; }

	    public UserType Type { get; set; }

	    public UserStatus Status { get; set; }

	    public bool IsVerified { get; set; }

	    public bool IsLocked { get; set; }

	    public bool HasBeenOnboarded { get; set; }

	    public DateTime? VerifiedOn { get; set; }

	    public DateTime? LastSeenOn { get; set; }

        public ICollection<Invoice> Invoice { get; set; }
    }
}
