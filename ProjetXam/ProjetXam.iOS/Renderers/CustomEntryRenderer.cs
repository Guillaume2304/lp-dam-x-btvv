using System; 
using CoreGraphics; 
using ProjetXam; 
using ProjetXam.iOS;
using UIKit;
using Xamarin.Forms; 
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry),typeof(CustomEntryRenderer))]

namespace ProjetXam.iOS{ public class CustomEntryRenderer: EntryRenderer
        {
        protected override void OnElementChanged(ElementChangedEventArgs < Entry > e)
            {
            base.OnElementChanged(e); 
            if (e.OldElement == null) 
            {
                Control.Layer.CornerRadius = 20; 
                Control.Layer.BorderWidth = 3f;
                Control.Layer.BorderColor = Color.FromRgb(30, 144, 255).ToCGColor();
                Control.Layer.BackgroundColor = Color.LightGray.ToCGColor(); 
                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0)); 
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
                Control.TintColor = UIColor.FromRGB(30, 144, 255);
            }
        }
    }
}