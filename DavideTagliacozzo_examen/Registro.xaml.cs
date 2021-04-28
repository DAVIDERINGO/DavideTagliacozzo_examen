using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DavideTagliacozzo_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string clave)
        {
            InitializeComponent();
            lblUser.Text = "USUARIO LOGEADO ES: " + usuario;
        }

       

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double dato1 = Convert.ToDouble(txtDato2.Text);
            double resultado = 1800 - dato1;
            resultado = resultado / 3;
            resultado = resultado * 1.05;
            txtDato3.Text = resultado.ToString();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
             DisplayAlert("Notificacion", "Elemento  guardado con exito", "OK");

            string nombre = txtDato1.Text;
            string total = txtDato3.Text;
            string usuario = lblUser.Text;
            
                await Navigation.PushAsync(new Resumen(nombre, total, usuario));
            
            


        }
    }
}