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
    public partial class Registro : ContentPage
    {
        const Double valorTotal = 3000.0;
        const Double porcentajeInteres = 0.05;
        const int numeroCuotas = 5;
        const Double valorInteres = valorTotal * porcentajeInteres;
        const Double totalAPagar = valorTotal + (valorInteres * numeroCuotas);
        string nombreUsuarioLogeado;
        public Registro(string nombreUsuario)
        { 
            InitializeComponent();
            nombreUsuarioLogeado = nombreUsuario;
            txtMonto.Text = "0.0";
            lblPagoMensual.Text = "0.0";
            
            lblUsuario.Text = "Usuario conectado: " + nombreUsuario;
        }


        private  void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (txtMonto.Text.Trim() == "" || txtMonto.Text.Trim() == "0.0") {
                DisplayAlert("Alerta", "Ingrese el valor del pago inicial", "Cerrar");
                return;
            }
            Double tPagoMensual = 0.0;

            tPagoMensual = Convert.ToDouble(txtMonto.Text);

            if (tPagoMensual > 0 && tPagoMensual < 3000.0)
            {
                Console.WriteLine("tPagoMensual" + tPagoMensual);

                Double subPago = valorTotal - tPagoMensual;
                Console.WriteLine("subPago"+ subPago);
                Double valorTotalCuota = (subPago / numeroCuotas) + valorInteres;
                Console.WriteLine("valorInteres" + valorInteres);
                Console.WriteLine("valorTotalCuota" + valorTotalCuota);
                lblPagoMensual.Text = Convert.ToString(valorTotalCuota) + "$";
            }
            else {
                DisplayAlert("Alerta", "El valor debe estar mayor a cero y menos a tres mil", "Cerrar");
            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "") {
                DisplayAlert("Alerta", "Ingrese nombre del estudiante", "Cerrar");
            } else if (lblPagoMensual.Text.Trim() == "" || lblPagoMensual.Text.Trim() == "0.0"
                || lblPagoMensual.Text.Trim() == "0") {
                DisplayAlert("Alerta", "Por favor calcular el valor de la cuota", "Cerrar");
            }
            else {
                DisplayAlert("Exito", "Elemento guardado correctamente", "Cerrar");
                await Navigation.PushAsync(new Resumen(nombreUsuarioLogeado,txtNombre.Text , totalAPagar));
            }

        }
    }
}