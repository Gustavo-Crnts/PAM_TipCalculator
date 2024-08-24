namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {


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

        }

        private void RoundLowButton_Clicked(object sender, EventArgs e)
        {

        }

        private void TipSlider_ValueChanged(object sender, EventArgs e)
        {
            TipPercentLabel.Text = TipSlider.Value.ToString("#") + "%";
        }

        private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Pegar o valor inserido ex: 100
            double Valor = Convert.ToDouble(AmountEntry.Text);
           
            //Calcular o valor da gorjeta de acordo com a porcentagem
            double ValorDaGorjeta = Valor * (TipSlider.Value / 100);
            //Calcular o valor total, sendo a soma do valor + a gorjeta
            double ValorTotal = Valor + ValorDaGorjeta;

            TotalLabel.Text = ValorTotal.ToString();
            TipLabel.Text = ValorDaGorjeta.ToString();
        }
    }
}
