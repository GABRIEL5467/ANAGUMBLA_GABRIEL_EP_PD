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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string nombre)
        {
            InitializeComponent();
            lblUser.Text = usuario;
        }

        private void btnTotal_Clicked(object sender, EventArgs e)
        {
           
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double vc = Convert.ToDouble(TxtValorCurso.Text);
                double s1 = Convert.ToDouble(TxtDato1.Text);
                double s2 = Convert.ToDouble(TxtDato2.Text);
               

                double inscripcion = (vc - s1);
                double porcentaje = ((vc * 1.05)-vc);
                double cuota1 = (inscripcion / 3+porcentaje);
               
                double vtotal = (vc + porcentaje);

                TxtDato2.Text = cuota1.ToString();
              
                TxtPorcentaje.Text = porcentaje.ToString();
                TxtVtotal.Text = vtotal.ToString();

            }
          
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
    }
}

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = TxtDato0.Text;
            string vtotal = TxtVtotal.Text;

            await Navigation.PushAsync(new Resumen(nombre,vtotal));
            await DisplayAlert("OK", "Elemento guardado con exito", "OK");

        }
    }
}