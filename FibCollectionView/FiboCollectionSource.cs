using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace collectionview
{
	public class FiboCollectionSource : UICollectionViewDataSource
	{
		static readonly double sqrt5 = Math.Sqrt(5);
		static readonly double const1 = 0.5 + 0.5 * sqrt5;
		static readonly double const2 = 0.5 - 0.5 * sqrt5;

		public FiboCollectionView CollectionView { get; set; }
		public List<int> Numbers { get; set; } = new List<int>();

		static int Fib(int n)
		{
			return (int)Math.Round((Math.Pow(const1, n) - Math.Pow(const2, n)) / sqrt5);
		}

		public FiboCollectionSource(FiboCollectionView collectionView)
		{
			CollectionView = collectionView;

			// Init numbers collection
			for (int n = 1; n < 100; ++n)
			{
				Numbers.Add(Fib(n));
			}
		}

		public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = collectionView.DequeueReusableCell("MyCell", indexPath) as FiboViewCell;
			cell.Title = Numbers[(int)indexPath.Item].ToString();

			return cell;
		}

		public override nint GetItemsCount(UICollectionView collectionView, nint section)
		{
			return Numbers.Count;
		}

		public override nint NumberOfSections(UICollectionView collectionView)
		{
			return 1;
		}


	}
}
