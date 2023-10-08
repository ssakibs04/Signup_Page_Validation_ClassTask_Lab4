using System;
using System.ComponentModel.DataAnnotations;

namespace Lab4.Models
{
    public class SignUp
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Name must be between 4 and 50 characters.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Name must contain only letters.")]
        public string Name  { get; set; }



        [Required (ErrorMessage ="UserID is Required")]
        [StringLength(12 ,MinimumLength =4 ,ErrorMessage ="UserId must be between 4 and 12 characters.")]
        [RegularExpression("^[a-zA-Z0-9_-]*$", ErrorMessage = "UserID must contain only letters, numbers, underscores, or dashes.")]
        public string UserID { get; set; }


        [Required(ErrorMessage ="PassWord Is Required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")] 
        public string Password { get; set; }
     
        [Required (ErrorMessage="ID is Required")]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$", ErrorMessage = "ID must be in the format **-*****-*.")]
        public string ID { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"\d{2}-\d{5}-\d{1}$*@student@aiub@edu$", ErrorMessage = "Invalid Email format.")]
        public string Email { get; set; }
        [Required]

        public Nullable <System.DateTime> DOB {  get; set; }
    }
}