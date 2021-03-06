﻿using Android.Content;
using Android.Graphics.Drawables;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using ZapApp.Componentes;
using ZapApp.Droid.Components;

[assembly: ExportRenderer(typeof(ClearEntry), typeof(ClearEntryRenderer))]
namespace ZapApp.Droid.Components
{
    public class ClearEntryRenderer : EntryRenderer
    {
        public ClearEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}