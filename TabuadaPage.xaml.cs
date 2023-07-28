namespace Tabuada;

public partial class TabuadaPage : ContentPage
{
	public TabuadaPage()
	{
		InitializeComponent();
	}

    private void btExecutar_Clicked(object sender, EventArgs e)
    {
		try 
		{
			Label label;
			int num = Convert.ToInt32(Numero.Text);
			vsTabuada.Clear();
			for( int i = 0; i < 11; i++ ) 
			{
				label = new Label { 
				Text = $"{num} X {i} = {i * num}",
				FontSize = 18,
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.Center
				};
				
				vsTabuada.Children.Add( label );
			}
		}catch(Exception ex) 
		{
			DisplayAlert("Error", "Informe apenas números", "OK");
		}
    }
}