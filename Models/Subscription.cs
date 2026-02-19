using System.ComponentModel.DataAnnotations;

namespace Pop_Alexandru_Aurel_Proiect.Models
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }

        [Required]
        public int MemberId { get; set; }
        public Member? Member { get; set; }

        [Required]
        public int SubscriptionTypeId { get; set; }
        public SubscriptionType? SubscriptionType { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
