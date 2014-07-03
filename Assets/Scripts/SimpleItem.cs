using UnityEngine;
using System.Collections;
using GildedRose.Console;


public class SimpleItem : Item, IItem
{
	public SimpleItem (string name, int quality, int sellIn)
	{
		this.Name = name;
		this.Quality = quality;
		this.SellIn = sellIn;
	}

	public void UpdateSellIn ()
	{
		SellIn--;
	}

	public void UpdateQuality ()
	{
		if (Quality > 0)
			Quality--;

		if( SellIn < 0 && Quality > 0)
			Quality--;
	}
}