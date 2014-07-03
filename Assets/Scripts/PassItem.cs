using UnityEngine;
using System.Collections;
using GildedRose.Console;


public class PassItem : Item, IItem
{
	public PassItem (string name, int quality, int sellIn)
	{
		this.Name = name;
		this.Quality = quality;
		this.SellIn = sellIn;
	}

	public void UpdateQuality ()
	{
		if (Quality < 50)
			Quality++;

		AddMoreQuality ();
		ResetQuality ();
	}

	public void UpdateSellIn ()
	{
		SellIn--;
	}

	private void AddMoreQuality ()
	{
		if (SellIn < 11 && Quality < 50)
			Quality++;
		if (SellIn < 6 && Quality < 50)
			Quality++;
	}

	private void ResetQuality ()
	{
		if (SellIn < 0)
			Quality = 0;
	}
}