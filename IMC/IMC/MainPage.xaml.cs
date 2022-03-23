using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txt_peso.Text);
            double altura = Convert.ToDouble(txt_altura.Text);

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                DisplayAlert("Seu IMC é: " + Math.Round(imc, 2), "Você está a baixo do peso", "OK");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                DisplayAlert("Seu IMC é: " + Math.Round(imc,2) , "Peso Normal", "OK");
            }
            else if (imc >= 25 && imc < 30)
            {
                DisplayAlert("Seu IMC é: " + Math.Round(imc, 2), "Excesso de Peso", "OK");
            }
            else if (imc >= 30 && imc < 35)
            {
                DisplayAlert("Seu IMC é: " + Math.Round(imc, 2), "Obesidade Classe I", "OK");
            }
            else if (imc >= 35 && imc < 40)
            {
                DisplayAlert("Seu IMC é: " + Math.Round(imc, 2), "Obesidade Clase II", "OK");
            }
            else
            {
                DisplayAlert("Seu IMC é: " + Math.Round(imc, 2), "Obesidade Classe III", "OK");
            }



            
        }

    }
}
