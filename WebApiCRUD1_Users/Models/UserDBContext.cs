using Microsoft.EntityFrameworkCore;

namespace WebApiCRUD1_Users.Models
{
    public class UserDBContext : DbContext
    {

        public UserDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Users> user { get; set; }

    }
}
