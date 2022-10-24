using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKM_API.Models
{
    public class User
    {
        public User(int Id, string Password)
        {
            this.Id = Id;
            this.Password = Password;
        }

        [Key]
        [ForeignKey("Employee")]
        public int Id { get; private set; }
        public string Password { get; private set; }

        public Employee Employee { get; set; }
    }
}
