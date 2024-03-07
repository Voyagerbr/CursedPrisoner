namespace CursedPrisoner;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
//Botão De Jogar
private void ButtonStartIsClicked(object sender,EventArgs args)
{
	 Application.Current.MainPage = new GamePage();
}
// Botão dos Créditos
 private void ButtonCreditIsClicked(object sender, EventArgs args)
  {
    creditsFrame.IsVisible = true;
  }
  //Botão pra voltar dos créditos
private void ButtonBackMenuIsClicked(object sender, EventArgs args)
  {
    creditsFrame.IsVisible = false;
  }
}

