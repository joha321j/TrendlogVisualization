using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendlogVisualization.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public int SaleValue { get; set; }
        public string PicturePath { get; set; }
    }
}
