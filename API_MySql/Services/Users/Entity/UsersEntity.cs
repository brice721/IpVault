using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web.UI.WebControls;
using API_Attempt.Services.Users.Model;

namespace API_Attempt.Services.Users.Entity
{
    [Table("Users")]
    public class UsersEntity
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}