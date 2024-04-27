using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Gamer gamer { get; set; }
        public Game Game { get; set; }
        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
