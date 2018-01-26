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
    public class FirstFragment : Fragment
    {
        public static FirstFragment NewInstance() {

            FirstFragment fragment = new FirstFragment();

            fragment.Arguments = new Bundle();

            return fragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return inflater.Inflate(Resource.Layout.FirstLayout, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            EditText etName = (EditText)view.FindViewById(Resource.Id.etName);

            Button btnAvanza = (Button)this.View.FindViewById(Resource.Id.btnAvanzaA2nd);

            btnAvanza.Click += delegate{
                var fragment = SecondFragment.NewInstance(etName.Text);

                var transaction = this.FragmentManager.BeginTransaction();

                transaction.Replace(Resource.Id.mainContainer, fragment);

                transaction.AddToBackStack(null);

                transaction.Commit();
            };
        }
    }
}