namespace MauiAppConvertisseur
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCelsiusToFarenheitClicked(object sender, EventArgs e)
        {
            if (double.TryParse(CelsiusEntry.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                FarenheitEntry.Text = fahrenheit.ToString("F2");
            }
            else
            {
                DisplayAlert("Erreur", "Veuillez entrer un nombre valide pour °C.", "OK");
            }
        }

        private void OnFarenheitToCelsiusClicked(object sender, EventArgs e)
        {
            if (double.TryParse(FarenheitEntry.Text, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                CelsiusEntry.Text = celsius.ToString("F2");
            }
            else
            {
                DisplayAlert("Erreur", "Veuillez entrer un nombre valide pour °F.", "OK");
            }
        }
    }

}