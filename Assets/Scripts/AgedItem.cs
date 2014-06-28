using UnityEngine;
using System.Collections;
using GildedRose.Console;


public class AgedItem : Item, IItem
{
	public AgedItem (string name, int quality, int sellIn)
	{
		this.Name = name;
		this.Quality = quality;
		this.SellIn = sellIn;
	}

	public void UpdateQuality ()
	{
		if (Quality < 50)
			Quality++;

		SellIn--;

		if( SellIn < 0 && Quality < 50)
			Quality++;

	}
}