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

namespace hetodia.Controladores
{
    [Activity(Label = "CRegistroClinico2")]
    public class CRegistroClinico2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Se hace visible la vista asociada
            SetContentView(Resource.Layout.registroPaciente2);
        }
    }
}