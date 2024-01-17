using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final_Nardelli_Nancy.Models
{
    internal class SoldProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Stock { get; set; }
        public int SaleId { get; set; }
    }
}
