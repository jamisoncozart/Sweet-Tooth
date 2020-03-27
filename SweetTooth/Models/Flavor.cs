using System.Collections.Generic;

namespace RecipeBox.Models
{
	public class Flavor
	{
		public Flavor()
		{
			this.Sweets = new HashSet<CategoryFlavor>();
		}
    public int FlavorId { get; set; }
		public string Name { get; set; }
		public virtual ICollection<CategoryFlavor> Sweets { get; }
	}
}