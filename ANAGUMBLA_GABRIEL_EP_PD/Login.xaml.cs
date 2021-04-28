using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ANAGUMBLA_GABRIEL_EP_PD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public static String NombreUsuario = "estudiante2021";

        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string clave = txtPass.Text;

            if ((usuario == "estudiante2021") && (clave == "uisrael2021"))
            {
                await Navigation.PushAsync(new Registro(usuario, clave));
            }
            else
            {
                lblResultado.Text = "El usuario o contraseña es incorrecto";
            }


        }

        private void btnAbrir_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}