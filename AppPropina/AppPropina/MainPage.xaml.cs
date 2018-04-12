using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPropina
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            bntCalcular.Clicked += BntCalcular_Clicked;
		}

        private void BntCalcular_Clicked(object sender, EventArgs e)
        {
            var total = decimal.Parse(entTotal.Text);
            var propina = int.Parse(entPropina.Text);
            var personas = int.Parse(entPersonas.Text);
            var totalpropina = (total * (propina / 100));
            //Calcular propina
            txtTotalPropina.Detail = totalpropina.ToString();
            txtPropinaPersona.Detail = (totalpropina / personas).ToString("C");
            txtTotalPersona.Detail = (total + totalpropina / personas).ToString("C");
            txtTotal.Detail = (total + totalpropina).ToString("C");
        }
    }
}
