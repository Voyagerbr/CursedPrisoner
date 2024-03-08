namespace CursedPrisoner;

public partial class GamePage : ContentPage
{
	 List<HistorySteps> history = new List<HistorySteps>();
	HistorySteps CurrentHistoryStep;
    public GamePage()
	{
		InitializeComponent();
	
	//history.Add(new HistorySteps()
	//{
		//IdPage="0",
		//Text="Olá novamente Prisioneiro, você parece estar mais cansado do que da última vez, o que está esperando? Saia para a floresta rapidamente, você se lembrará de tudo ao longo do caminho",
		//HasAnswer=false,
	//});
	//history.Add(new HistorySteps()
	//{
		//IdPage="1",
		//Text="Após alguns minutos caminhando por aquela floresta úmida, escura e fedida, você encontra uma encruzilhada, que se separa em duas direções. Olhando o caminho à esquerda parece claro e leva a uma cidade, dizem que lá é bonito. Olhando à direita vê-se um bosque escuro e lá há uma pequena aldeia. Você pretende seguir qual caminho?",
		//HasAnswer=true,
		//Answer01="Esquerda",
		//Answer02="Direita",
		//IdLevelAnswer01="2",
		//IdLevelAnswer02="3"
	//});
	}
    
}