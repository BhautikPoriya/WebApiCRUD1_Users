using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCRUD1_Users.Models;

namespace WebApiCRUD1_Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserDBContext context;

        public UsersController(UserDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("GetUsers")]
        public List<Users> GetUsers()
        {
            return context.user.ToList();
        }

        [HttpGet]
        [Route("GetUserbyId")]
        public Users GetUserByID(int id)
        {
            return context.user.Where(x => x.UserID == id).FirstOrDefault();
        }


        [HttpPost]
        [Route("AddUser")]
        public string AddUser(Users user)
        {
            context.user.Add(user);
            context.SaveChanges();
            return "User Added";
        }

        [HttpPut]
        [Route("UpdateUser")]
        public string UpdateUser(Users user)
        {
            context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return "User Updated";
        }

        [HttpDelete]
        [Route("DeleteUser")]
        public string DeleteUser(int i)
        {
            Users user = context.user.Where(x => x.UserID == i).FirstOrDefault();
            if (user != null)
            {
                context.user.Remove(user);
                context.SaveChanges();
                return "User Deleted";
            } else 
            {
                return "User Not Found!";
            }
            
        }

    }
}
