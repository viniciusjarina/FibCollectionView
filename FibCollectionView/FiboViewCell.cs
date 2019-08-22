using Foundation;
using System;
using UIKit;

namespace collectionview
{
    public partial class FiboViewCell : UICollectionViewCell
    {
        public FiboViewCell (IntPtr handle) : base (handle)
        {
        }

		public string Title
		{
			get { return fibLabel.Text; }
			set { fibLabel.Text = value; }
		}

		public override void AwakeFromNib()
		{
			Console.WriteLine("AwekeFrom nib Cell");
		}
	}
}