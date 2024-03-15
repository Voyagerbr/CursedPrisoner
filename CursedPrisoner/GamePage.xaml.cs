namespace CursedPrisoner;

public partial class GamePage : ContentPage
{
	 List<HistorySteps> history = new List<HistorySteps>();
	HistorySteps CurrentHistoryStep;
    public GamePage()
	{
		InitializeComponent();
		history.Add(new HistorySteps()
		{
			IdPage=0,
			Texts="Olá novamente Prisioneiro, você parece estar mais cansado do que da última vez, o que está esperando? Saia para a floresta rapidamente, você se lembrará de tudo ao longo do caminho",
			HasAnswer=false,
		});
		
		history.Add(new HistorySteps()
		{
			IdPage=1,
			Texts="Teste daora",
			HasAnswer=true,
			Answer01="Esquerda",
			Answer02="Direita"
		});
		Start();
	}
 
    void Start()
	{
		ChangeCurrentStoryStep(0);
	}
	void ChangeCurrentStoryStep(int id)
  {
	CurrentHistoryStep = history.Where(d=> d.IdPage == id).First();
    FillPage();
  }
	void FillPage()
	{
		
		labelText.Text = CurrentHistoryStep.Texts;
		if(CurrentHistoryStep.HasAnswer)
		{
			NextButton.IsVisible=false;
			Button01.IsVisible = true;
      		Button02.IsVisible = true;
			Button01.Text = CurrentHistoryStep.Answer01;
			Button02.Text = CurrentHistoryStep.Answer02;
		}
		else 
		{
			NextButton.IsVisible=true;
			Button01.IsVisible = false;
      		Button02.IsVisible = false;
		}
	}
	void NextButtonIsClicked(object sender, EventArgs args)
	{
		var nextId = CurrentHistoryStep.IdPage + 1;
    	ChangeCurrentStoryStep(nextId);
	}
	
}
