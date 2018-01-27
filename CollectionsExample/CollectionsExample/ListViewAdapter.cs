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
using Java.Lang;

namespace CollectionsExample
{
    public class ListViewAdapter : BaseAdapter
    {
        private IList<CancionModel> canciones;

        public ListViewAdapter(IList<CancionModel> canciones)
        {
            this.canciones = canciones;
        }
        public override int Count
        {
            get
            {
                return this.canciones.Count();
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return this.canciones[position];
        }

        public override long GetItemId(int position)
        {
            return this.GetItem(position).GetHashCode();
        }

        public override View GetView(int position, View reusableView, ViewGroup parent)
        {
            if (reusableView == null)
            {
                var inflater = LayoutInflater.From(parent.Context);
                reusableView = inflater.Inflate(Resource.Layout.ItemLayout, parent, false);
            }

            CancionModel song = (CancionModel)this.GetItem(position);

            TextView tvTitle = (TextView)reusableView.FindViewById(Resource.Id.txtTitle);
            TextView tvSubtitle = (TextView)reusableView.FindViewById(Resource.Id.txtSubTitle);

            tvTitle.Text = song.Title;
            tvSubtitle.Text = song.SubTitle;


            return reusableView;
        }
    }
}