using System.ComponentModel.DataAnnotations;

namespace Ajax_Crud.Models
{
    public class User
    {
        [Key]
        public int UserId { set; get; }

        [Required]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Name must be 3 to 50 characters")]
        public string UserName { set; get; }

        [Required]
        [EmailAddress]
        public string Email { set; get; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be 3 to 50 characters")]
        public string Address { set; get; }

        [Required]
        [StringLength(20, MinimumLength =3,ErrorMessage ="Passord must be 3 to 20 characters")]
        public string Password { set; get; }
    }
}
