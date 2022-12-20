using System;
using Ruokalistat.tk.Models;

namespace Digiruokalista.com.Models
{
	public class RuokaTykkays
	{
		public int Id { get; set; }
		public Ruoka RuokaId { get; set; }
		public string IP { get; set; }
	}
}

