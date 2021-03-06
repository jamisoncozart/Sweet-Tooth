using System.Collections.Generic;

namespace SweetTooth.Models
{
  public class Sweet
  {
    public Sweet()
    {
        this.Flavors = new HashSet<SweetFlavor>();
    }

    public int SweetId { get; set; }
    public string Name { get; set; }
		public virtual ApplicationUser User { get; set; }
    public virtual ICollection<SweetFlavor> Flavors { get; set; }
  }
}