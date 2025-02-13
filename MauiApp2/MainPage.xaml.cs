using Sharpnado.Tabs;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private TabHostView _tabHostView = new()
        {
            HeightRequest = 50,
            //IsSegmented = true,
            //SegmentedHasSeparator = true,
            //SegmentedOutlineColor = ColorPicker.BorderGray,
            //TabType = TabType.Fixed,
            //VerticalOptions = LayoutOptions.Center,
            //HorizontalOptions = LayoutOptions.Fill,
            SelectedIndex = 0,
        };

        private SegmentedTabItem _tabBuy = new()
        {
            Label = "Test1",
            LabelSize = 16,
            FontFamily = "OpenSansBold",
            SelectedLabelColor = ColorPicker.White,
            SelectedTabColor = ColorPicker.LightBlue,
            UnselectedLabelColor = ColorPicker.LigthGrayText,
        };

        private SegmentedTabItem _tabRent = new()
        {
            Label = "Test2",
            LabelSize = 16,
            FontFamily = "OpenSansBold",
            SelectedLabelColor = ColorPicker.White,
            SelectedTabColor = ColorPicker.LightBlue,
            UnselectedLabelColor = ColorPicker.LigthGrayText,
        };

        public MainPage()
        {
            InitializeComponent();
            _tabHostView.Tabs.Add(_tabBuy);
            _tabHostView.Tabs.Add(_tabRent);

            PageContent.Add(_tabHostView);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }
    }
}