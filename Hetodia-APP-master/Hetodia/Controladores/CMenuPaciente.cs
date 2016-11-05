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
    [Activity(Label = "Menú Principal")]
    public class CMenuPaciente : Activity
    {
        // Atributos
        Button bRegistroClinico;
        Button bPerfil;
        Button bDieta;
        Button bMedicamentos;
        Button bEjercicios;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Se hace visible la vista asociada
            SetContentView(Resource.Layout.menuPaciente);

            // Se asignan los eventos respectivos a cada botón
            bRegistroClinico = FindViewById<Button>(Resource.Id.misDatosClinicos);
            bRegistroClinico.Click += BRegistroClinico_Click;

            bPerfil = FindViewById<Button>(Resource.Id.menuPerfil);
            bPerfil.Click += BPerfil_Click;

            bDieta = FindViewById<Button>(Resource.Id.menuDieta);
            bDieta.Click += BDieta_Click;

            bMedicamentos = FindViewById<Button>(Resource.Id.menuMedicamentos);
            bMedicamentos.Click += BMedicamentos_Click;

            bEjercicios = FindViewById<Button>(Resource.Id.ejercicios);
            bEjercicios.Click += BEjercicios_Click;
        }

        //Evento del boton bEjercicios
        private void BEjercicios_Click(object sender, EventArgs e)
        {
            Intent ejercicios = new Intent(this, typeof(CEjercicios));
            this.StartActivity(ejercicios);
        }

        //Evento del boton bMedicamentos
        private void BMedicamentos_Click(object sender, EventArgs e)
        {
            Intent medicamentos = new Intent(this, typeof(CEdicionMedicamentos));
            this.StartActivity(medicamentos);
        }

        //Evento del boton bDieta
        private void BDieta_Click(object sender, EventArgs e)
        {
            Intent dieta = new Intent(this, typeof(CDieta));
            this.StartActivity(dieta);
        }

        //Evento del boton bPerfil
        private void BPerfil_Click(object sender, EventArgs e)
        {
            Intent perfil = new Intent(this, typeof(CPerfilPaciente));
            this.StartActivity(perfil);
        }

        //Evento del boton bRegistroClinico
        void BRegistroClinico_Click(object sender, EventArgs e)
        {
            Intent registroClinico = new Intent(this, typeof(CRegistroClinico1));
            this.StartActivity(registroClinico);
        }
    }
}