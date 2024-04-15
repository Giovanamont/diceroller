using Microsoft.Maui.Storage;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DiceTypePicker.SelectedIndex = 0;
        }

        private void DiceBtn_Clicked(object sender, EventArgs e)
        {
            //Instanciação de um novo objeto dice do tipo Dice, através do construtor Dice();
            int sidesNumber = Convert.ToInt32(DiceTypePicker.SelectedItem);
            Dice dice = new Dice(sidesNumber);
            DiceResult.Text = Convert.ToString( dice.Rolar() );
        }

        private void DiceTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiceTypeImage.Source = $"d{DiceTypePicker.SelectedItem.ToString()}.png";
            
        }
    }

}
