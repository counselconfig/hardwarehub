using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COSE71197_DL.Controllers
{
    public class ContactController :Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
