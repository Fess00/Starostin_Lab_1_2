namespace Starostin_2;

public partial class FirstScheme : ContentPage
{
	public FirstScheme()
	{
		InitializeComponent();
        linePicker.SelectedIndex = 0;
	}

    void OnButtonClicked(object sender, EventArgs args)
    {
        Random rand = new();
        if (linePicker.SelectedItem.ToString() == "Прямая")
        {
            SchemeOne so = new(new Line(new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500)));
            so.Draw(2);
            img.Source = ImageSource.FromFile("firstschemeimage");
        }
        if (linePicker.SelectedItem.ToString() == "Кривая")
        {
            SchemeOne so = new(new Bezier(new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500)));
            so.Draw(4);
        }
    }
}