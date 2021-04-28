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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string total, string usuario)
        {
            InitializeComponent();
            lblUser.Text = "USUARIO LOGEADO ES: " + usuario;
            lblNombre.Text = "NOMBRE DEL ESTUDIANTE ES: " + nombre;
            lblTotal.Text = "TOTAL APAGAR MENSUAL POR 3 MESES ES: " + total;
        }
    }
}