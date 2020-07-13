using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Popsicle.ViewModel;
using System.ComponentModel;
using System;

namespace Popsicle.View
{
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCartPage : ContentPage
    {
        public MyCartPage()
        {
            InitializeComponent();
            BindingContext = new MyCartBiewModel(Navigation);
        }
    }
}