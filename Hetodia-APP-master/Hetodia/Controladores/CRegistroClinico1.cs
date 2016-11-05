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
    [Activity(Label = "Registro Clínico")]
    public class CRegistroClinico1 : Activity
    {
        //Atributos
        Button bPerfilHepatico;
        Button bPerfilLipidico;
        Button bContinuar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Se hace visible la vista asociada
            SetContentView(Resource.Layout.registroPaciente);

            //Se asignan los eventos respectivos a cada boton
            bPerfilHepatico = FindViewById<Button>(Resource.Id.buttonPerfilHepatico);
            bPerfilHepatico.Click += BPerfilHepatico_Click;

            bPerfilLipidico = FindViewById<Button>(Resource.Id.buttonPerfilLipidico);
            bPerfilLipidico.Click += BPerfilLipidico_Click;

            bContinuar = FindViewById<Button>(Resource.Id.buttonContinuar);
            bContinuar.Click += BContinuar_Click;
        }

        //Eventos del boton bContinuar
        private void BContinuar_Click(object sender, EventArgs e)
        {
            Intent continuar = new Intent(this, typeof(CRegistroClinico2));
            this.StartActivity(continuar);
        }

        //Eventos del boton bPerfilLipidico
        private void BPerfilLipidico_Click(object sender, EventArgs e)
        {
            Intent perfilLipidico = new Intent(this, typeof(CPerfilLipidico));
            this.StartActivity(perfilLipidico);
        }

        //Eventos del boton bPerfilHepatico
        private void BPerfilHepatico_Click(object sender, EventArgs e)
        {
            Intent perfilHepatico = new Intent(this, typeof(CPerfilHepatico));
            this.StartActivity(perfilHepatico);
        }
    }
}