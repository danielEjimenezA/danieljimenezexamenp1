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
    public partial class ResumenView : ContentPage
    {
        public ResumenView(String user, Decimal totalPagar, String nombre)
        {
            InitializeComponent();
            lblUser.Text = user;
            txtNombre.Text = nombre;
            txtTotalPagar.Text = totalPagar.ToString();
        }
    }
}