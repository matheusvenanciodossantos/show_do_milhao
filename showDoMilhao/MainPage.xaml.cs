namespace showDoMilhao;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
private void StarGame(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new PerguntasPage();
  }


}

