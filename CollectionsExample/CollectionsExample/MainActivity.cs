using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace CollectionsExample
{
    [Activity(Label = "CollectionsExample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ListView lvLista = (ListView)this.FindViewById(Resource.Id.lvList);

            ListViewAdapter adapter = new ListViewAdapter(generateDummy(20));

            lvLista.Adapter = adapter;

            lvLista.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {

                ListView lv = sender as ListView;
                ListViewAdapter adpter = (ListViewAdapter)lv.Adapter;
                CancionModel song = (CancionModel)adpter.GetItem(e.Position);

                System.Diagnostics.Debug.WriteLine("Presionó " + song);

            };
        }

        private IList<CancionModel> generateDummy(int count) {

            IList<CancionModel> Lista = new List<CancionModel>();

            for (int i = 0; i < count; i = i + i)
            {
                CancionModel song = new CancionModel();
                song.Title = "Title " + i;
                song.SubTitle = "SubTitule " + i;

                Lista.Add(song);
            }

            return Lista;
        }
    }
}

