using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Pages.Login
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }

        public void OnGet()
        {
            this.Credential = new Credential { Username = "admin" };

        }

        public void OnPost()
        {

        }

    }
        public class Credential
        {
            [Required]
            [Display(Name = "User Name")]
            public string Username { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

    
}
