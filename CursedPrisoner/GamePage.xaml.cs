using Microsoft.Maui.Controls;

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
		Texts="Após alguns minutos caminhando por aquela floresta úmida, escura e fedida, você encontra uma encruzilhada, que se separa em duas direções. Olhando o caminho à esquerda parece claro e leva a uma cidade, dizem que lá é bonito. Olhando à direita vê-se um bosque escuro e lá há uma pequena aldeia. Você pretende seguir qual caminho?",
		HasAnswer=true,
		Answer01="Esquerda",
		Answer02="Direita",
		IdLevelAnswer01=2,
		IdLevelAnswer02=3
	});
	history.Add (new HistorySteps()
	{
		IdPage=2,
		Texts="Após algumas horas andando, chegaste a Piddletown, as pessoas da cidade parecem já te reconhecer e oferecem alguns equipamentos. Em específico, uma lamparina e um cutelo.Qual você vai pegar",
		HasAnswer=true,
		Answer01="Lamparina",
		Answer02="Cutelo",
		IdLevelAnswer01=5,
		IdLevelAnswer02=6
	});
	history.Add(new HistorySteps()
		{
			IdPage=3,
			Texts="Após alguns minutos andando, você se depara com uma criatura estranha que fala algumas palavras em uma língua estrangeira em seu ouvido, você tenta a atacar mas ela devia e te dá uma espada de presente e fala para fazer bom uso dela",
			HasAnswer=false
		});
			history.Add(new HistorySteps()
		{
			IdPage=4,
			Texts="Depois de algum tempo você chega a uma taverna, as pessoas parecem felizes em te ver, e perguntam se você se lembra delas. Você se lembra?",
			HasAnswer=true,
			Answer01="Sim",
			Answer02="Não",
		});
			history.Add(new HistorySteps()
		{
			IdPage=5,
			Texts="Saindo da cidade você entra em um campo aberto, sem árvores e nem pessoas. Repentinamente aparece um cachorro, como se houvesse saído do chão e te ataca, o que você vai fazer?",
			HasAnswer=true,
			Answer01="Atacar",
			Answer02 = "Fugir",
			IdLevelAnswer01=995,
			IdLevelAnswer02=10

		});
		history.Add(new HistorySteps()
		{
			IdPage=6,
			Texts="Saindo da cidade você entra em um campo aberto, sem árvores e nem pessoas. Repentinamente aparece um cachorro, como se houvesse saído do chão e te ataca, o que você vai fazer?",
			HasAnswer=true,
			Answer01="Atacar",
			Answer02 = "Fugir"

		});
		history.Add(new HistorySteps()
		{
			IdPage=10,
			Texts="Você conseguiu fugir, mas está cansado e com sede",
			HasAnswer=false

		});history.Add(new HistorySteps()
		{
			IdPage=11,
			Texts="Você correu para o lado contrário da cidade e não tem nimguém por perto",
			HeroDied=true

		});
		history.Add(new HistorySteps()
	{
		IdPage=995,
		Texts = "Você tentou o atacar com  a lamparina, e a pele dele pegou fogo, porém , ele ainda conseguiu te devorar",
		HeroDied = true
	});
		history.Add(new HistorySteps()
	{
		IdPage=998,
		
		HeroDied = true
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
		if(CurrentHistoryStep.HeroDied)
		{
			FrameGameOver.IsVisible = true;
		}
		else
		{
			FrameGameOver.IsVisible = false;
		}
	}
	void NextButtonIsClicked(object sender, EventArgs args)
	{
		var nextId = CurrentHistoryStep.IdPage + 1;
    	ChangeCurrentStoryStep(nextId);
	}
	void Button01IsClicked(object sender, EventArgs args)
  {
	var IdButton01 = CurrentHistoryStep.IdLevelAnswer01;
    ChangeCurrentStoryStep(IdButton01);
  }
  void Button02IsClicked(object sender, EventArgs args)
  {
	var IdButton02 = CurrentHistoryStep.IdLevelAnswer02;
    ChangeCurrentStoryStep(IdButton02);
  }
  void ButtonRetryIsClicked(object sender,EventArgs args)
  {
	Application.Current.MainPage = new MainPage();
  }
}
