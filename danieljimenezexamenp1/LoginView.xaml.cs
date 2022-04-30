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
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private async void btnLogueo_Clicked(object sender, EventArgs e)
        {
            String user = txtUser.Text;
            String password = txtPassword.Text;
            if (user == "daniel2022" && password == "uisrael2022")
            {
                await Navigation.PushAsync(new RegistroView(user));
            }
            else
            {
                await DisplayAlert("Login Alert", "Usuario o Contraseña incorrectos", "Salir");
            }
        }
    }
}