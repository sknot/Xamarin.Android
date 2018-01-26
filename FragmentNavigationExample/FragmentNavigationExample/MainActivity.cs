using Android.App;
using Android.Widget;
using Android.OS;
using FragmentNavigationExample.Fragments;

namespace FragmentNavigationExample
{
    [Activity(Label = "FragmentNavigationExample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            if (savedInstanceState == null)
            {
                Fragment first = FirstFragment.NewInstance();

                FragmentManager manager = this.FragmentManager;
                FragmentTransaction transaction = manager.BeginTransaction();

                transaction.Add(Resource.Id.mainContainer, first);

                transaction.Commit();
            }
        }
    }
}

