using System.ComponentModel.DataAnnotations;

namespace WebApiCRUD1_Users.Models
{
    public class Users
    {

        [Key]
        public int UserID{ get; set; }

        public string UserName { get; set; } = null!;
        public string UserMobile { get; set; } = null!;

    }
}
