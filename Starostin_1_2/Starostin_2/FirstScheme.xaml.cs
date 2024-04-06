namespace Starostin_2;

public partial class FirstScheme : ContentPage
{
	public FirstScheme()
	{
		InitializeComponent();
	}

    void OnButtonClicked(object sender, EventArgs args)
    {
        SchemeOne so = new(new Line(new Point(3, 7), new Point(120, 200)));
        so.Draw(2);
    }
}