using System.ComponentModel.DataAnnotations;

namespace EntryNow.Web.Models.Account
{
    public class Login
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}