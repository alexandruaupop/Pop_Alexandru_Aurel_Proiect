using System.ComponentModel.DataAnnotations;

namespace Pop_Alexandru_Aurel_Proiect.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }

        [Required(ErrorMessage = "Prenumele este obligatoriu")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Numele este obligatoriu")]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Specialization { get; set; }
        [Phone(ErrorMessage ="Telefon invalid")]
        public string Phone { get; set; }

        public ICollection<Member>? Members { get; set; }
    }
}
