using System.Collections.Generic;
using UnityEngine;

namespace GildedRose.Console
{
	public class Program
	{
		IList<IItem> Items;

		static void Main(string[] args)
		{
			Debug.Log("OMGHAI!");
			
			var app = new Program()
			{
				Items = new List<IItem>
				{
					new SimpleItem ("+5 Dexterity Vest", 10, 20),
					new AgedItem ("Aged Brie", 0, 2),
					new SimpleItem ("Elixir of the Mongoose", 7, 5),
					new LegendaryItem ("Sulfuras, Hand of Ragnaros", 80, 0),
					new PassItem ( "Backstage passes to a TAFKAL80ETC concert",  12,  5),
					new SimpleItem ("Conjured Mana Cake", 6, 3)
				}
			};
			
			app.UpdateItemsInfo ();
			
		}

		public Program ()
		{
			Items = new List<IItem> ();
		}

		public void AddItem (IItem item)
		{
			Items.Add (item);
		}
		
		public void UpdateItemsInfo()
		{
			foreach (IItem item in Items) 
			{
				item.UpdateSellIn ();
				item.UpdateQuality();	
			}
		}
	}
	
	public class Item
	{
		public string Name { get; set; }
		
		public int SellIn { get; set; }
		
		public int Quality { get; set; }
	}
	
}
