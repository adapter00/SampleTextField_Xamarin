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

        //this method is overRide From UITextView
        public override RectangleF GetCaretRectForPosition(UITextPosition position)
        {
            //Disable Carret
            return  RectangleF.Empty;
        }

        //this method is overRide From UITextView
        public override void AddGestureRecognizer(UIGestureRecognizer gestureRecognizer)
        {
            if (gestureRecognizer.GetType() == typeof(UILongPressGestureRecognizer))
            {
                //Disable Magnifying Glass in UITextField
                gestureRecognizer.Enabled = false;
            }
            base.AddGestureRecognizer(gestureRecognizer);
        }
    }
}