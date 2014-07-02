using UnityEngine;
using System.Collections;
using GildedRose.Console;

public class ConjuredItem : Item, IItem
{
	private int rateToDisccount = 2;
	public ConjuredItem (string name, int quality, int sellIn)
	{
		this.Name = name;
		this.Quality = quality;
		this.SellIn = sellIn;
	}
	
	public void UpdateQuality ()
	{
		if (Quality > 0)
			Quality -= rateToDisccount;

		SellIn--;

		if (SellIn < 0 && Quality > 0)
			Quality -= rateToDisccount;

		if (Quality < 0)
			Quality = 0;
	}
}
