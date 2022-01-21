using System.Collections.Generic;

namespace BlazorApp.Pages
{
    public partial class TypeParamComponent<TValue>
    {
		public List<TValue> GenericList { get; set; }
	}
}
