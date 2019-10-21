using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendlogVisualization.Models
{
    public class IndexViewModel
    {
        public SuperDataClass SuperData { get; set; }
        public int TotalOrders => SuperData.TotalOrders;
    }
}
