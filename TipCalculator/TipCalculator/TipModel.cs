using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Xamarin.Forms;

namespace TipCalculator
{
    public class TipModel : INotifyPropertyChanged
    {
        private decimal _total;
        private int _propina;
        private int _noPersonas;
        private decimal _totalPropina;
        private decimal _totalConPropina;
        private decimal _propinaPorPersona;
        private decimal _totalPorPersona;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public Command OperationsCommand { get; set; }

        public TipModel()
        {
            OperationsCommand = new Command(DoOperations);
        }

        //event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        //{
        //    add
        //    {

        //    }

        //    remove
        //    {

        //    }
        //}

        private void DoOperations()
        {
            TotalPropina = (Total * Propina) / 100;
            TotalConPropina = (TotalPropina + Total);
            PropinaPorPersona = (TotalPropina / noPersonas);
            TotalPorPersona = ((Total + TotalPropina) / noPersonas);
        }

        public decimal Total
        {
            get => _total;
            set
            {
                _total = value;
                //PropertyChanged(this, new PropertyChangedEventArgs(nameof(Total)));
                OnPropertyChanged();
            }
        }

        public int Propina
        {
            get => _propina;
            set
            {
                _propina = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Propina)));
            }
        }

        public int noPersonas
        {
            get => _noPersonas;
            set
            {
                _noPersonas = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(noPersonas)));
            }
        }

        public decimal TotalPropina
        {
            get => _totalPropina;
            set
            {
                _totalPropina = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(TotalPropina)));
            }
        }

        public decimal TotalConPropina
        {
            get => _totalConPropina;
            set
            {
                _totalConPropina = value;
                //OnPropertyChanged();
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(TotalConPropina)));
            }
        }

        public decimal PropinaPorPersona
        {
            get => _propinaPorPersona;
            set
            {
                _propinaPorPersona = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(PropinaPorPersona)));
                //OnPropertyChanged();
            }
        }

        public decimal TotalPorPersona
        {
            get => _totalPorPersona;
            set
            {
                _totalPorPersona = value;
                //OnPropertyChanged();
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(TotalPorPersona)));
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(name)));
        }

    }
}
