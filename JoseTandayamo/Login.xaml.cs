using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JoseTandayamo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

          private async void btnIniciar_Clicked(object sender, EventArgs e){

            string usuario = "joseTandayamo2022";
            string contrasena = "uisrael2022";

            string tUsuario = txtUsuario.Text;
            string tContrasena = txtContrasena.Text;

            if (usuario == tUsuario & contrasena == tContrasena)
            {
                DisplayAlert("Exito", "USUARIO CORRECTO", "Aceptar");
                await Navigation.PushAsync(new Registro(tUsuario));
            }
            else
            {
                DisplayAlert("Alerta", "USUARIO NO EXISTE", "Cerrar");
            }
        }

    }
}