namespace Starostin_2;

public partial class SecondScheme : ContentPage
{
	public SecondScheme()
	{
		InitializeComponent();
	}

    void OnButtonClicked(object sender, EventArgs args)
    {
        this.FadeTo(0);
        this.FadeTo(100);
        SchemeOne so = new(new Bezier(new Point(3, 7), new Point(120, 200), new Point(50, 50), new Point(500, 315)));
        so.Draw(4);
    }
}