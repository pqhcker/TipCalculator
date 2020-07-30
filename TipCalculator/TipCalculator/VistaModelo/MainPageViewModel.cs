using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TipCalculator.VistaModelo
{
    public class MainPageViewModel
    {
        public Command OperationsCommand { get; set; }
        public TipModel tipModel { get; set; }
        public MainPageViewModel()
        {
            OperationsCommand = new Command(DoOperations);
            tipModel = new TipModel
            {
                noPersonas = 2
            };
        }

        private void DoOperations()
        {
            tipModel.TotalPropina = (tipModel.Total * tipModel.Propina) / 100;
            tipModel.TotalConPropina = (tipModel.TotalPropina + tipModel.Total);
            tipModel.PropinaPorPersona = (tipModel.TotalPropina / tipModel.noPersonas);
            tipModel.TotalPorPersona = ((tipModel.Total + tipModel.TotalPropina) / tipModel.noPersonas);
        }
    }
}
