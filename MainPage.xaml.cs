namespace MyGestures;

public partial class MainPage : ContentPage
{
	bool worked = false;
	public MainPage()
	{
		InitializeComponent();
	}

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		if (!worked)
		{
            (sender as Frame).BackgroundColor = Color.Parse("Blue");
			worked = true;
        }
		else
		{
            (sender as Frame).BackgroundColor = Color.Parse("Red");
			worked = false;
        }
	}

	private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
	{
		(sender as Frame).BackgroundColor = Color.Parse("Blue");
	}
}

