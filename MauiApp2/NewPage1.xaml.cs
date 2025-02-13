namespace MauiApp2;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new MainPage());
        //Navigation.RemovePage(this);
        Navigation.PopAsync();
    }
}