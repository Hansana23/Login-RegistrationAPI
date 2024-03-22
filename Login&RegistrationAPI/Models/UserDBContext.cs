using Microsoft.EntityFrameworkCore;

namespace Login_RegistrationAPI.Models
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDTO> UsersDTO { get; set; }
    }
}
