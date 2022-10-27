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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombreUsuario,string nombreEstudiante, Double totalAPagar)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: " + nombreUsuario;
            lblNombreEstudiante.Text = nombreEstudiante;
            lblTotalAPagar.Text = Convert.ToString(totalAPagar) + "$";
        }
    }
}