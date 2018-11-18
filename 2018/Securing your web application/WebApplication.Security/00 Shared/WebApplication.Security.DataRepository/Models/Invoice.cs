using System;

namespace WebApplication.Security.DataRepository.Models
{
    public class Invoice
    {
        public int Id { get; set; }

	    public DateTime CreatedOn { get; set; }

	    public int UserId { get; set; }

	    public string Number { get; set; }

	    public DateTime IssuedOn { get; set; }

	    public DateTime? Duedate { get; set; }

	    public decimal TotalAmount { get; set; }

        public User User { get; set; }
    }
}
