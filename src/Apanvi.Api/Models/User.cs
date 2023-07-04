using System.ComponentModel.DataAnnotations.Schema;

namespace Apanvi.API.Models
{
    [Table("users")]
    public class User : Person 
    {
        public String Roles { get; set; }
        public bool CanEdit { get; set; } = true;
        public bool CanDelete { get; set; } = true;

        public User(string name, string roles) 
        {
            Name = name;
            Roles = roles;
            CanEdit = roles.Contains("Admin") || roles.Contains("SuperAdmin");
            CanDelete = roles.Contains("SuperAdmin");
        }
    }
}


        