using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManagementProjectTeam.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        public int Rating{ get; set; }
        public string Comments { get; set; }
        [Required]
        public DateTime SubmittedTimestamp { get; set; }

        [ForeignKey("User")]
        public int Id { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

    }
}
