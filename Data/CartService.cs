using System;

namespace BlazorApp.Data
{
	public class CartService
	{
		public delegate void CartHasUpdated();
		public event CartHasUpdated OnCartUpdated;
		public int CartCount { get; set; }

		public void IncreaseCount()
		{
			CartCount++;
		}

		public void DecreaseCount()
		{
			if (CartCount > 0)
			{
				CartCount--;
			}
		}
	}
}
