using System.Reflection;

namespace sd2;

public partial class SecondScheme : ContentPage
{
    SchemeTwo st;

    public SecondScheme()
	{
		InitializeComponent();
        linePicker.SelectedIndex = 0;
        st = null;
    }

    async void OnButtonClicked(object sender, EventArgs args)
    {
        Random rand = new();
        if (linePicker.SelectedItem.ToString() == "Прямая")
        {
            st = new(new Line(new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500)));
            st.Draw(4); 
        }
        if (linePicker.SelectedItem.ToString() == "Кривая")
        {
            st = new(new Bezier(new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500)));
            st.Draw(4);
        }
        var res = await ImageSourceToByteArrayAsync(ImageSource.FromFile("secondschemeimage.png"));
        img.Source = ImageSource.FromStream(() => new MemoryStream(res));
        GenerateSVGSecondScheme.IsEnabled = true;
    }

    public static async Task<byte[]> ImageSourceToByteArrayAsync(ImageSource imageSource)
    {
        using var stream = File.OpenRead(
            HomePath.HP + "secondschemeimage.png");
        byte[] bytesAvailable = new byte[stream.Length];
        stream.Read(bytesAvailable, 0, bytesAvailable.Length);
        return bytesAvailable;
    }

    void OnButtonSVGClicked(object sender, EventArgs args)
    {
        st.SaveSVG();
    }
}