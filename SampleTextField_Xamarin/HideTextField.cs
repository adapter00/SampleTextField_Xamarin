using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Drawing;

namespace SampleTextField_Xamarin
{
    [Register("HideTextField")]
    public class HideTextField :UITextField
    {
        public HideTextField(IntPtr bundle):base(bundle)
        {
        }

        public override RectangleF GetCaretRectForPosition(UITextPosition position)
        {
            return  RectangleF.Empty;
        }
    }
}