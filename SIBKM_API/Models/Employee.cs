using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKM_API.Models
{
    public class Employee
    {
        public Employee(int Id, string FullName, string Email)
        {
            this.Id = Id;
            this.FullName = FullName;
            this.Email = Email;
        }

        [Key]
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
    }
}
