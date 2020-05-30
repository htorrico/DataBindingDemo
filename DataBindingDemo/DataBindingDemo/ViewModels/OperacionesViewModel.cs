using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DataBindingDemo.ViewModels
{
    public class OperacionesViewModel : ViewModelBase
    {
        //public int Valor1 { get; set; }
        //public int Valor2 { get; set; }

        #region Declarar Propiedades
        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }

        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultSuma;
        public int ResultSuma
        {
            get { return resultSuma; }
            set
            {
                if (resultSuma != value)
                {
                    resultSuma = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion



        #region Comandos 
        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }

        #endregion
        public OperacionesViewModel()
        {
            Sumar = new Command(() =>
            {
                ResultSuma = Valor1 + Valor2;
            });
        
        }
    }
}

