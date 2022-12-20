
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Digiruokalista.com.Models
{
    public class Hintahistoria
    {
        public int ID { get; set; }
        public Ruokalistat.tk.Models.Ruoka Ruoka { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Hinta { get; set; }
        public DateTime PVM { get; set; }
    }
}
