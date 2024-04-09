using System.Reflection;

namespace Starostin_2;

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
        var path = AppDomain.CurrentDomain.BaseDirectory;
        string dir = Path.GetDirectoryName(path);
        var parent = Directory.GetParent(dir);
        var p = parent.Parent.Parent.Parent.Parent;
        using var stream = File.OpenRead(
            p.ToString() + @"\Resources\Images\secondschemeimage.png");
        byte[] bytesAvailable = new byte[stream.Length];
        stream.Read(bytesAvailable, 0, bytesAvailable.Length);
        return bytesAvailable;
    }

    void OnButtonSVGClicked(object sender, EventArgs args)
    {
        st.SaveSVG();
    }
}