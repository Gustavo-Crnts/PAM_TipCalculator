﻿using System.Diagnostics;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        double valorTotal = 0;
        double valorDaGorjeta = 0;
        double valor = 0;


        public MainPage()
        {
            InitializeComponent();
        }


        private void SetLowButton_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 15;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void SetHighButton_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 20;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";

        }

        private void RoundHighButton_Clicked(object sender, EventArgs e)
        {
          

            valorDaGorjeta = Math.Ceiling(valorDaGorjeta);
            valorTotal = Math.Ceiling(valorTotal);

            TipLabel.Text = valorDaGorjeta.ToString("C");
            TotalLabel.Text = valorTotal.ToString("C");
        }

        private void RoundLowButton_Clicked(object sender, EventArgs e)
        {
            valorDaGorjeta = Math.Floor(valorDaGorjeta);
            valorTotal = Math.Floor(valorTotal);

            TipLabel.Text = valorDaGorjeta.ToString("C");
            TotalLabel.Text = valorTotal.ToString("C");
        }

        private void TipSlider_ValueChanged(object sender, EventArgs e)
        {
            TipPercentLabel.Text = TipSlider.Value.ToString("#.##") + "%";

            try
            {

                //Pegar o valor inserido ex: 100
                valor = Convert.ToDouble(AmountEntry.Text);

                //Calcular o valor da gorjeta de acordo com a porcentagem
                valorDaGorjeta = valor * (TipSlider.Value / 100);

                //Calcular o valor total, sendo a soma do valor + a gorjeta
                valorTotal = valor + valorDaGorjeta;

                TotalLabel.Text = valorTotal.ToString("C");
                TipLabel.Text = valorDaGorjeta.ToString("C");

            }

            catch (Exception ex)
            {
                
                Debug.WriteLine(ex.ToString());

            }
        }





        private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            //fé em Deus
            try
            {

                //Pegar o valor inserido ex: 100
                 valor = Convert.ToDouble(AmountEntry.Text);

                //Calcular o valor da gorjeta de acordo com a porcentagem
                 valorDaGorjeta = valor * (TipSlider.Value / 100);

                //Calcular o valor total, sendo a soma do valor + a gorjeta
                 valorTotal = valor + valorDaGorjeta;

                TotalLabel.Text = valorTotal.ToString("C");
                TipLabel.Text = valorDaGorjeta.ToString("C");

            }

            catch (Exception ex)
            {
                
                Debug.WriteLine(ex.ToString());
                
            }
        }

        private void SetLowButton_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
