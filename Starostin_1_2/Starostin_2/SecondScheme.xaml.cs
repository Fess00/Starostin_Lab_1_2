namespace Starostin_2;

public partial class SecondScheme : ContentPage
{
	public SecondScheme()
	{
		InitializeComponent();
        linePicker.SelectedIndex = 0;
    }

    void OnButtonClicked(object sender, EventArgs args)
    {
        Random rand = new();
        if (linePicker.SelectedItem.ToString() == "Прямая")
        {
            SchemeTwo st = new(new Line(new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500)));
            st.Draw(2);
            img.Source = ImageSource.FromFile("secondschemeimage"); 
        }
        if (linePicker.SelectedItem.ToString() == "Кривая")
        {
            SchemeTwo st = new(new Bezier(new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500)));
            st.Draw(4);
        }
    }
}