using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace FragmentNavigationExample.Fragments
{
    public class SecondFragment : Fragment
    {
        private String name;
        public static SecondFragment NewInstance(String name)
        {
            SecondFragment fragment = new SecondFragment();

            fragment.Arguments = new Bundle();
            fragment.Arguments.PutString("NAME", name);
            
            return fragment;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
            if (this.Arguments != null) {
                this.name = this.Arguments.GetString("NAME");
            }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return inflater.Inflate(Resource.Layout.SecondLayout, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            TextView tvName = (TextView)view.FindViewById(Resource.Id.tvname);
            tvName.Text = this.name;

            Button btnBack = (Button)this.View.FindViewById(Resource.Id.btnBack);
            btnBack.Click += delegate
            {
                this.FragmentManager.PopBackStack();
            };

            Button btnGoTo3rd = (Button)this.View.FindViewById(Resource.Id.btnGoTo3rd);
            btnGoTo3rd.Click += delegate
            {
                var fragment = ThirdFragment.NewInstance();

                var transaction = this.FragmentManager.BeginTransaction();

                transaction.Replace(Resource.Id.mainContainer, fragment);

                //transaction.AddToBackStack(null);

                transaction.Commit();
            };
        }
    }
}