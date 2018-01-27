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

namespace CollectionsExample
{
    public class CancionModel:Java.Lang.Object
    {
        public String Title { get; set; }
        public String SubTitle { get; set; }
        public String PublishDate { get; set; }
        public CancionModel()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}