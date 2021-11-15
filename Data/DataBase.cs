using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{
	public class DataBase
	{
		public List<Item> GetItems() => items;
		public void AddItem(Item item) => items.Add(item);
		public bool RemoveItem(Item item) => items.Remove(item);

		private List<Item> items;
		public DataBase()
		{
			items = new List<Item>()
			{
				new Item()
				{
					Id = Guid.NewGuid().ToString(),
					ImageLink = @"http://test.eaglebusinesssoftware.com/ENS-Open-Flip-Wedge-Stand/image/item/ENSOFWS",
					Quantity = 1,
					Price=99.00M,
					Detail = "ENS Open Flip Wedge Stand",
					Unit = "1kg/p",
					Weight = "10kg"
				},
				new Item()
				{
					Id = Guid.NewGuid().ToString(),
					ImageLink = @"http://test.eaglebusinesssoftware.com/APG-S100-Cash-Drawer/image/item/APGS100",
					Quantity = 1,
					Price=239.00M,
					Detail = "Epson TM-T88V Thermal Receipt Printer",
					Unit = "1000/ct",
					Weight = ""
				},
				new Item()
				{
					Id = Guid.NewGuid().ToString(),
					ImageLink = @"http://test.eaglebusinesssoftware.com/Epson-TM-T88V-Thermal-Receipt-Printer/image/item/ETMT88VUP",
					Quantity = 1,
					Price=395.00M,
					Detail = "APG S100 Cash Drawer",
					Unit = "1/pc",
					Weight = ""
				}
			};
		}
	}
}
