using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using thinkinapp2.Controls;
using thinkinapp2.Droid.Renderers;
using System.ComponentModel;
using Xamarin.Forms;
using thinkinapp2.Droid.Controls;

[assembly: ExportRenderer(typeof(ImageWithTouch), typeof(ImageWithTouchRenderer))]
namespace thinkinapp2.Droid.Renderers
{
    public class ImageWithTouchRenderer : ViewRenderer<ImageWithTouch, DrawView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ImageWithTouch> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                SetNativeControl(new DrawView(Context));
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == ImageWithTouch.CurrentLineColorProperty.PropertyName)
            {
                UpdateControl();
            }
        }

        private void UpdateControl()
        {
            Control.CurrentLineColor = Element.CurrentLineColor.ToAndroid();
        }
    }
}