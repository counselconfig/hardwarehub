using COSE71197_DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COSE71197_DL.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Hardware> HardwareOnSale { get; set; }
    }
}
