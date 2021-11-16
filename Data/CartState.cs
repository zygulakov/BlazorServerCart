using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Data
{
	public class CartState
	{
		private readonly DataBase dataBase;
		public CartState(DataBase db)
		{
			this.dataBase = db;
		}
		public event Action OnChange;
		private void NotifyStateChanged() => OnChange?.Invoke();
		public int CartCount { get => Items.Sum(i => i.Quantity); }

		private List<Item> items;
		public List<Item> Items
		{
			get
			{
				if (items == null)
				{
					items = dataBase.GetItems();
				}
				return items;
			}
		}
		public void AddItem(Item item)
		{
			items.Add(item);
		}

		public void RemoveItem(Item item)
		{
			items.Remove(item);
			NotifyStateChanged();
		}

		public void IncreaseItem(Item item, int count)
		{
			Items.Find(i => i.Id == item.Id).Quantity += count;
			NotifyStateChanged();
		}

		public void DecreaseItem(Item item, int count)
		{
			Items.Find(i => i.Id == item.Id).Quantity -= count;
			NotifyStateChanged();
		}
	}
}
