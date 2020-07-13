using Xamarin.Forms;
using Popsicle.ViewModel;
using Xamarin.Forms.Xaml;
using System.ComponentModel;

namespace Popsicle.View
{
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel(Navigation);
        }
    }
}