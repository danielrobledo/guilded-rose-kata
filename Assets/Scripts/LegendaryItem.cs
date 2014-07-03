using UnityEngine;
using System.Collections;
using GildedRose.Console;


public class LegendaryItem : Item, IItem
{
	public LegendaryItem (string name, int quality, int sellIn)
	{
		this.Name = name;
		this.Quality = quality;
		this.SellIn = sellIn;
	}
	public void UpdateSellIn ()
	{}
	public void UpdateQuality ()
	{}
}