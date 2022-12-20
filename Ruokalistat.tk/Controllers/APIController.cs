using Digiruokalista.com.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ruokalistat.tk.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Digiruokalista.com.Controllers
{
    [ApiController]
    public class APIController : Controller
    {
        private tietokantaContext db;
        public APIController(tietokantaContext db)
        {
            this.db = db;
        }
    }
}
