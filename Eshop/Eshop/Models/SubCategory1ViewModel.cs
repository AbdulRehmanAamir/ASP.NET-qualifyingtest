using Eshop.Models.DbModels;

namespace Eshop.Models
{
	public class SubCategory1ViewModel
	{
		public string Name { get; set; }
		public List<SubCategory2ViewModel> ProductCatList { get; set; }
	}
}
