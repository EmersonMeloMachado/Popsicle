using Xamarin.Forms;
using Popsicle.ViewModel;
using Xamarin.Forms.Xaml;
using System.ComponentModel;

namespace Popsicle
{
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(Navigation);
        }
    }
}
