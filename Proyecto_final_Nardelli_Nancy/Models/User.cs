using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final_Nardelli_Nancy.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LastName { get; set; }
        public int UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
