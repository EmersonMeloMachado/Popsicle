using System;
using Popsicle.View;
using Xamarin.Forms;
using Popsicle.Models;
using Popsicle.Service;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Popsicle.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<Popsicles> Popsicle { get; set; }
        public HomeViewModel(INavigation navigation)
        {
            Navigation = navigation;
            GetAllPopsicle();
        }

        private void GetAllPopsicle()
        {
            Popsicle = new ObservableCollection<Popsicles>(DataService.GetAllPopsicle());
        }

        public ICommand MyCartCommand => new Command(async () =>
        {
            try
            {
                await Navigation.PushAsync(new MyCartPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }
}
