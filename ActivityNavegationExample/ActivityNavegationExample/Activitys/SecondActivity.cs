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

namespace ActivityNavegationExample
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            this.SetContentView(Resource.Layout.Second);

            Intent intent = this.Intent;

            TextView textView = (TextView)this.FindViewById(Resource.Id.TextView);
            textView.Text = "Hola" + intent.GetStringExtra("Valor1") + " Bienvenido";

            int valor2 = intent.GetIntExtra("Valor2", -1);
            System.Diagnostics.Debug.WriteLine(valor2);

            Button btnRegresar = (Button)this.FindViewById(Resource.Id.btnRegresar);
            btnRegresar.Click += BtnRegresar_Click;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Finish();
        }
    }
}