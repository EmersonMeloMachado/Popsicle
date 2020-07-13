using System;
using Xamarin.Forms;
using System.Windows.Input;
using Popsicle.View;

namespace Popsicle.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        private Color _backgroundColor = Color.FromHex("#BCECF5");
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor, value); }
        }
        public MainViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

        public ICommand BackgroundColorCommand => new Command(() =>
        {
            try
            {
                BackgroundColor = BackgroundColor == Color.FromHex("#BCECF5") ? Color.FromHex("#FBCEDC") : Color.FromHex("#BCECF5");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });

        public ICommand HomePageCommand => new Command(async () =>
        {
            try
            {
                await Navigation.PushAsync(new HomePage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }
}
