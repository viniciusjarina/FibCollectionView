using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace collectionview
{
	public class FibCollectionDelegate : UICollectionViewDelegate
	{
		public FiboCollectionView CollectionView { get; set; }
		public FibCollectionDelegate(FiboCollectionView collectionView)
		{
			CollectionView = collectionView;
		}

		public override bool ShouldHighlightItem(UICollectionView collectionView, NSIndexPath indexPath)
		{
			return true;
		}

		public override void ItemHighlighted(UICollectionView collectionView, NSIndexPath indexPath)
		{
			// Get cell and change to green background
			var cell = collectionView.CellForItem(indexPath);
			cell.ContentView.BackgroundColor = UIColor.SystemOrangeColor;
		}

		public override void ItemUnhighlighted(UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = collectionView.CellForItem(indexPath);
			cell.ContentView.BackgroundColor = UIColor.SystemTealColor;
		}
	}
}
