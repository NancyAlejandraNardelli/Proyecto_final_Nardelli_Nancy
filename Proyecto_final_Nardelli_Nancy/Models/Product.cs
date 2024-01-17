using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final_Nardelli_Nancy.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Decimal Cost { get; set; }
        public decimal SellingPrice { get; set; }
        public int Stock { get; set; }
        public int UserId { get; set; }
    }
}
