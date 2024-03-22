using System.ComponentModel.DataAnnotations;

namespace Login_RegistrationAPI.Models
{
    public class UserDTO
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
