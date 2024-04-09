using Microsoft.Maui.Platform;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;

namespace Starostin_2;

public partial class FirstScheme : ContentPage
{
    SchemeOne so;

    public FirstScheme()
	{
		InitializeComponent();
        linePicker.SelectedIndex = 0;
        so = null;
    }

    async void OnButtonClicked(object sender, EventArgs args)
    {
        Random rand = new();
        if (linePicker.SelectedItem.ToString() == "Прямая")
        {
            so = new(new Line(new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500)));
            so.Draw(4);
        }
        if (linePicker.SelectedItem.ToString() == "Кривая")
        {
            so = new(new Bezier(new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500),
            new Point(rand.NextDouble() * 500, rand.NextDouble() * 500)));
            so.Draw(4);
        }
        var res = await ImageSourceToByteArrayAsync(ImageSource.FromFile("firstschemeimage.png"));
        img.Source = ImageSource.FromStream(() => new MemoryStream(res));
        GenerateSVGFir1stScheme.IsEnabled = true;
    }

    public static async Task<byte[]> ImageSourceToByteArrayAsync(ImageSource imageSource)
    {
        using var stream = File.OpenRead(
            @"D:\CODE\C#\Starostin_Lab_1_2\Starostin_1_2\Starostin_2\Resources\Images\firstschemeimage.png");
        byte[] bytesAvailable = new byte[stream.Length];
        stream.Read(bytesAvailable, 0, bytesAvailable.Length);
        return bytesAvailable;
    }

    void OnButtonSVGClicked(object sender, EventArgs args)
    {
        so.SaveSVG();
    }
}