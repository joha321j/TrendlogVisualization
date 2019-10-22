using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendlogVisualization.Models
{
    public class IndexViewModel
    {
        public List<SuperDataClass> SuperDatas { get; set; }
        public int TotalOrders => SuperDatas.Sum(data => data.TotalOrders);

        public int TotalClientProfits => SuperDatas.Sum(data => data.ClientProfits);
        public int PeopleInterested => SuperDatas.Sum(data => data.PeopleInterested);
    }
}
