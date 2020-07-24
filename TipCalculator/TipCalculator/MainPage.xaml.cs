using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCalcular_OnClicked(object sender, EventArgs e)
        {
            var total = (decimal.Parse(txtTotal.Text == null ? "0" : txtTotal.Text));
            var propina = (int.Parse(txtPropina.Text == null ? "0" : txtPropina.Text));
            var noPersonas = (int.Parse(txtPersonas.Text == null ? "1" : txtPersonas.Text));

            if (noPersonas == 0)
            {
                DisplayAlert("Advertencia", "No puede dividirse la cuenta entre 0 personas", "Cerrar");
                return;
            }

            var totalPropina = (total * propina) / 100;

            lblPropina.Detail = totalPropina.ToString("C", CultureInfo.CreateSpecificCulture("es-CR"));
            lblTotal.Detail = (totalPropina + total).ToString("C", CultureInfo.CreateSpecificCulture("es-CR"));
            lblPropinaxPersona.Detail = (totalPropina / noPersonas).ToString("C", CultureInfo.CreateSpecificCulture("es-CR"));
            lblTotalxPersona.Detail = ((total + totalPropina) / noPersonas).ToString("C", CultureInfo.CreateSpecificCulture("es-CR"));
        }
    }
}
