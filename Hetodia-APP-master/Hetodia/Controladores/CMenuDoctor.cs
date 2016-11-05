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
    [Activity(Label = "Hetodia")]
    public class CMenuDoctor : Activity
    {
        // Atributos
        Button bPerfil;
        Button bInicio;
        Button bPacientes;
        Button bMensajes;
        Button bConfiguracion;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Se hace visible la vista asociada
            SetContentView(Resource.Layout.menuDoctor);

            //Se asignan los eventos respectivos a cada botón
            bPerfil = FindViewById<Button>(Resource.Id.perfilDoctor);
            bPerfil.Click += BPerfil_Click;

            bPacientes = FindViewById<Button>(Resource.Id.pacientes);
            bPacientes.Click += BPacientes_Click;

            bMensajes = FindViewById<Button>(Resource.Id.mensajes);
            bMensajes.Click += BMensajes_Click;


            bConfiguracion = FindViewById<Button>(Resource.Id.configuracion);
            bConfiguracion.Click += BConfiguracion_Click;
        }

        // Eventos del boton bPerfil
        private void BPerfil_Click(object sender, EventArgs e)
        {
            Intent perfil = new Intent(this, typeof(CPerfilDoctor));
            this.StartActivity(perfil);
        }

        //Eventos del boton bPacientes
        private void BPacientes_Click(object sender, EventArgs e)
        {
            Intent pacientes = new Intent(this, typeof(CPerfilDoctorPaciente)); // Falta vista con la lista de pacientes, por lo tanto, este boton redirige a la vista de un paciente del doctor
            this.StartActivity(pacientes);
        }

        //Eventos del boton bMensajes
        private void BMensajes_Click(object sender, EventArgs e)
        {
            //Intent mensajes = new Intent(this, typeof());   //Falta vista de los mensajes
           // this.StartActivity();
        }

        //Eventos del boton bConfiguracion
        private void BConfiguracion_Click(object sender, EventArgs e)
        {
            Intent configuracion = new Intent(this, typeof(CConfiguraciones));
            this.StartActivity(configuracion);
        }
    }
}