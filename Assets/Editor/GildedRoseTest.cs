using UnityEngine;
using System.Collections;
using NUnit.Framework;
using GildedRose.Console;

public class GildedRoseTest 
{
	private Program store;

	[SetUp]
	public void SetUp()
	{
		store = new Program ();
	}

	[Test]
	public void ItemDexterityLostQualityWithUpdate ()
	{
		SimpleItem item = new SimpleItem ("+5 Dexterity Vest", 10, 20);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (9 , item.Quality);
	}
	
	[Test]
	public void ItemDexterityLostDoubleQualityWithUpdate ()
	{
		SimpleItem item = new SimpleItem ("+5 Dexterity Vest", 10, -1);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (8 , item.Quality);
	}

	[Test]
	public void CheckSellInDecreasedAfterUpdate ()
	{
		SimpleItem item = new SimpleItem ("+5 Dexterity Vest", 10, -1);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (-2 , item.SellIn);
	}

	[Test]
	public void ItemAgedBrieGainsQualityWithUpdate()
	{
		AgedItem item = new AgedItem ("Aged Brie", 0, 2);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (1, item.Quality);
	}

	[Test]
	public void ItemAgedBrieGainedDoubleQualityWithUpdate ()
	{
		AgedItem item = new AgedItem ("Aged Brie", 0, -1);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (2 , item.Quality);
	}

	[Test]
	public void ItemBackstagePassesGainOneQualityWhenSellInGreaterThanEleven ()
	{
		PassItem item = new PassItem ( "Backstage passes to a TAFKAL80ETC concert",  12,  15);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (13 , item.Quality);
	}

	[Test]
	public void ItemBackstagePassesGainTwoQualityWhenSellInLessThanEleven ()
	{
		PassItem item = new PassItem ( "Backstage passes to a TAFKAL80ETC concert",  12,  10);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (14 , item.Quality);
	}

	[Test]
	public void ItemBackstagePassesGainThreeQualityWhenSellInLessThanSix ()
	{
		PassItem item = new PassItem ( "Backstage passes to a TAFKAL80ETC concert",  12,  5);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (15 , item.Quality);
	}

	[Test]
	public void ItemBackstagePassesQualityIsZeroIfSellInIsLessThanZero ()
	{
		PassItem item = new PassItem ( "Backstage passes to a TAFKAL80ETC concert",  12,  -1);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (0 , item.Quality);
	}

	[Test]
	public void ItemSulfurasKeptQualityWithUpdate ()
	{
		LegendaryItem item = new LegendaryItem ("Sulfuras, Hand of Ragnaros", 20, 10);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (20 , item.Quality);
	}

	[Test]
	public void ItemSulfurasKeptSellInWithUpdate ()
	{
		LegendaryItem item = new LegendaryItem ("Sulfuras, Hand of Ragnaros", 20, 10);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (10 , item.SellIn);
	}

	[Test]
	public void ItemConjuredLostTwoQualityWithUpdate ()
	{
		ConjuredItem item = new ConjuredItem ("Conjured", 20, 10);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (18, item.Quality);
	}

	[Test]
	public void ItemConjuredLostSellInWithUpdate ()
	{
		ConjuredItem item = new ConjuredItem ("Conjured", 20, 10);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (9, item.SellIn);
	}

	[Test]
	public void ItemConjuredLostDoubleQualityIfSellInLessThanZero ()
	{
		ConjuredItem item = new ConjuredItem ("Conjured", 20, -1);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (16, item.Quality);
	}

	[Test]
	public void ItemConjuredQualityCannotBeLessThanZero ()
	{
		ConjuredItem item = new ConjuredItem ("Conjured", 1, -1);
		store.AddItem (item);
		store.UpdateItemsInfo ();
		Assert.AreEqual (0, item.Quality);
	}
}