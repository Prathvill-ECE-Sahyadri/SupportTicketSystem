using System;
using System.ComponentModel.DataAnnotations;

namespace SupportTicketSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; } = "Open";

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string UserId { get; set; } // FK to AspNetUsers
    }
}
