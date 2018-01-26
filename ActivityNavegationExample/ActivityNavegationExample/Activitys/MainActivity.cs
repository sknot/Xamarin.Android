using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace ActivityNavegationExample
{
    [Activity(Label = "ActivityNavegationExample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            EditText editText = (EditText)this.FindViewById(Resource.Id.Input);
            Button btnAvanza = (Button)this.FindViewById(Resource.Id.btnNavegar);

            btnAvanza.Click += delegate
            {
                Intent intent = new Intent(this, typeof(SecondActivity));
                intent.PutExtra("Valor1", editText.Text);
                Intent.PutExtra("Valor2", 28);

                this.StartActivity(intent);
            };
            //btnAvanza.Click += BtnAvanza_Click;
        }

        //private void BtnAvanza_Click(object sender, System.EventArgs e)
        //{
        //    Intent intent = new Intent(this, typeof(SecondActivity));
        //    intent.PutExtra("Valor1", editText.);
        //    Intent.PutExtra("Valor2", 28);

        //    this.StartActivity(intent);
        //}
    }
}

