//using Xamarin.KotlinX.Coroutines;

namespace MauiD;

public partial class MainPage : ContentPage
{
    Thread qwe = Thread.CurrentThread;
	public MainPage()
	{
        InitializeComponent();

    }

    private async void Star_Clicked(object sender, EventArgs e)
    {
        for(int i = 0; i < 3; i++)
        {
            for(int q = 0; q < 3; q++)
            {
                if (q == 1 && i == 1){

                    continue;
                }
                ProgressBar n = new ProgressBar();
                Gr.Add(n, q, i);
                if(Math.IEEERemainder(q, i) == 0)
                {
                    await n.ProgressTo(1, 2000, Easing.BounceIn);
                }
                else
                {
                    await n.ProgressTo(1, 2000, Easing.CubicIn);
                }
                
            }
        }
        //First.IsVisible = true;
        //await First.ProgressTo(1, 2000, Easing.CubicIn);
        //Second.IsVisible = true;
        //await Second.ProgressTo(1, 2000, Easing.CubicIn);
        //T.IsVisible = true;
        //await T.ProgressTo(1, 2000, Easing.CubicIn);
        //Four.IsVisible = true;
        //await Four.ProgressTo(1, 2000, Easing.CubicIn);
        //Fi.IsVisible = true;
        //await Fi.ProgressTo(1, 2000, Easing.CubicIn);
        //Si.IsVisible = true;
        //await Si.ProgressTo(1, 2000, Easing.CubicIn);
        //Se.IsVisible = true;
        //await Se.ProgressTo(1, 2000, Easing.CubicIn);
        //E.IsVisible = true;
        //await E.ProgressTo(1, 2000, Easing.CubicIn);
        //Star.IsEnabled = false;
    }
}

