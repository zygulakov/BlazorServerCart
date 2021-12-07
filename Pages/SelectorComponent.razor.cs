using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorApp.Pages
{
	public partial class SelectorComponent
	{
		[Parameter]
		public string Label { get; set; }
		[Parameter]
		public List<string> Items { get; set; }
	}
}
