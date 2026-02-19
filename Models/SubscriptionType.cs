using System.ComponentModel.DataAnnotations;

namespace Pop_Alexandru_Aurel_Proiect.Models
{
    public class SubscriptionType
    {
        public int SubscriptionTypeId { get; set; }

        [Required(ErrorMessage = "Numele este obligatoriu")]
        [StringLength(50)]
        public string Name { get; set; } // ex: Basic, Premium, VIP

        [Required(ErrorMessage = "Durata in zile este obligatorie")]
        [Range(1, 365)]
        public int DurationInDays { get; set; } // durata abonamentului

        [Required(ErrorMessage = "Pretul este obligatoriu")]
        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }

        public ICollection<Subscription>? Subscriptions { get; set; }
    }
}
