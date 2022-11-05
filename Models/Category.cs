using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COSE71197_DL.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Hardware> Hardwares { get; set; }
    }
}
