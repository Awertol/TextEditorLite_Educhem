namespace TextEditor;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	string vysledek = ""; //vytvoření proměnné "vysledek"
    private void btnPrevest_Clicked(object sender, EventArgs e)
    {
		vysledek = vstupText.Text; //přepsání hodnoty v proměnné "vysledek"
		if(rbCAPSLOCK.IsChecked)
		{
			vysledek = vysledek.ToUpper();
		}
		else if(rbMalaPismena.IsChecked)
		{
			vysledek = vysledek.ToLower();
        }
		else if (rbObratit.IsChecked)
		{
			char[] poleZnaku = vysledek.ToCharArray();
			Array.Reverse(poleZnaku);
			vysledek = new string(poleZnaku);
		}
		DisplayAlert("Výsledek operace", vysledek, "OK");
    }

    private void btnZkopirovat_Clicked(object sender, EventArgs e)
    {
		Clipboard.SetTextAsync(vysledek);
    }
}

