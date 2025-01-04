using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthSystem.Models
{
    public class PasswordResetToken
    {
        public PasswordResetToken() 
        {
            this.ExperationTime = DateTime.Now.AddMinutes(5); 
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Tocken {  get; set; }
        public DateTime ExperationTime { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }


    }
}
