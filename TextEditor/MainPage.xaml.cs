namespace TextEditor;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	string vysledek = ""; //vytvoření proměnné "vysledek"
    private void btnPrevest_Clicked(object sender, EventArgs e)
    {
		try //program se pokusí provést tento kód
		{
			vysledek = vstupText.Text; //přepsání hodnoty v proměnné "vysledek"
			if (rbCAPSLOCK.IsChecked)
			{
				vysledek = vysledek.ToUpper();
			}
			else if (rbMalaPismena.IsChecked)
			{
				vysledek = vysledek.ToLower();
			}
			else if (rbObratit.IsChecked)
			{
				char[] poleZnaku = vysledek.ToCharArray();
				Array.Reverse(poleZnaku);
				vysledek = new string(poleZnaku);
			}
		} //pokud se v něm vyskytne jakákoli chyba -> zamezí jejímu provedení (zachytí ji) - program "skočí" do větve catch 
		catch (Exception ex)
		{
			DisplayAlert("Chyba", "Zkuste zadat jiný text", "OK");
		}
		DisplayAlert("Převedený text: ", vysledek, "OK");
    }

    private void btnZkopirovat_Clicked(object sender, EventArgs e)
    {
		Clipboard.SetTextAsync(vysledek);
    }
}

