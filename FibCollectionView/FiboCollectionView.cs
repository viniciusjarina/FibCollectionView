using Foundation;
using System;
using UIKit;

namespace collectionview
{
    public partial class FiboCollectionView : UICollectionView
    {
        public FiboCollectionView (IntPtr handle) : base (handle)
        {
        }

		public override void AwakeFromNib()
		{
			DataSource = new FiboCollectionSource(this);
			Delegate = new FibCollectionDelegate(this);
		}
	}
}