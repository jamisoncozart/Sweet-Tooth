using System.Collections.Generic;

namespace SweetTooth.Models
{
	public class Flavor
	{
		public Flavor()
		{
			this.Sweets = new HashSet<SweetFlavor>();
		}
    public int FlavorId { get; set; }
		public string Name { get; set; }
		public virtual ICollection<SweetFlavor> Sweets { get; }
	}
}