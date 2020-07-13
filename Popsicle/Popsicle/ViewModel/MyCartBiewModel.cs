using Xamarin.Forms;
using Popsicle.Models;
using Popsicle.Service;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using System;

namespace Popsicle.ViewModel
{
    public class MyCartBiewModel : BaseViewModel
    {
        public ObservableCollection<Popsicles> Popsicle { get; set; }
        public MyCartBiewModel(INavigation navigation)
        {
            Navigation = navigation;
            GetAllPopsicle();
        }

        private void GetAllPopsicle()
        {
            Popsicle = new ObservableCollection<Popsicles>(DataService.GetAllPopsicle());
        }

        public ICommand PopHomeCommand => new Command(async () =>
        {
            try
            {
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }
}
