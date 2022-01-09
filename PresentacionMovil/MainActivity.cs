using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using System;

namespace PresentacionMovil
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            botones();
            
        }

        private void botones()
        {
            var registrarseBoton = FindViewById(Resource.Id.btnRegistrarse);
            registrarseBoton.Click += Registrarse_Click;
            var iniciarSesionBoton = FindViewById(Resource.Id.btnIngresar);
            iniciarSesionBoton.Click += Iniciar_Click;
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(RegistroActivity));
            StartActivity(intent);
        }
        private void Iniciar_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(PedidosActivity));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        
    }
}