using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace danieljimenezexamenp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroView : ContentPage
    {
        Decimal totalPagar = 0;
        public RegistroView(String user)
        {
            InitializeComponent();
            lblUser.Text = user;
            DisplayAlert("Login", "Bienvenido " + user, "Cerrar");
        }

        private void btnCalcularPago_Clicked(object sender, EventArgs e)
        {
            if (txtCuotaInicial.Text != "" && txtNombre.Text != "")
            {
                Decimal cuotaInicial = Decimal.Parse(txtCuotaInicial.Text);
                if (cuotaInicial <= 3000)
                {
                    Decimal valor = 3000 - cuotaInicial;
                    Decimal cuota = (valor / 5) + (3000 * (decimal)0.05);
                    totalPagar = cuota * 5;
                    txtPagoMensual.Text = cuota.ToString();
                }
                else
                {   
                    DisplayAlert("Info", "La cuota inicial no puede ser mayo a 3000", "Cerrar");
                }
            }
            else
            {
                DisplayAlert("Info", "Ingrese la información solicitada", "Cerrar");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (txtCuotaInicial.Text != "" && txtNombre.Text != "" && txtPagoMensual.Text != "")
            {
                await DisplayAlert("Info", "Elemento guardado con éxito", "Continuar");
                await Navigation.PushAsync(new ResumenView(lblUser.Text, totalPagar, txtNombre.Text));
            }
            else
            {
                await DisplayAlert("Info", "Debe primero calcular antes de continuar", "Cerrar");
            }
        }
    }
}