using System.ComponentModel.DataAnnotations;

namespace Pop_Alexandru_Aurel_Proiect.Models
{
    public class Member
    {
        public int MemberId { get; set; }

        [Required(ErrorMessage = "Prenumele este obligatoriu")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Numele este obligatoriu")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Emailul este obligatoriu")]
        [EmailAddress(ErrorMessage = "Email invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefonul este obligatoriu")]
       // [Phone(ErrorMessage = "Telefon invalid")]
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        public int? TrainerId { get; set; }
        public Trainer? Trainer { get; set; }

        public ICollection<Subscription>? Subscriptions { get; set; }
    }
}
