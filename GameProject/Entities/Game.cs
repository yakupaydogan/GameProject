using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public decimal UnitPrice { get; set; }
        public string GameDescription { get; set; }
    }
}
