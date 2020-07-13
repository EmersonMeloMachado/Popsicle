using Popsicle.Models;
using System.Collections.ObjectModel;

namespace Popsicle.Service
{
    public class DataService
    {
        public static ObservableCollection<Popsicles> GetAllPopsicle()
        {
            return new ObservableCollection<Popsicles>()
            {
                new Popsicles()
                {
                    name = "Cupid",
                    flavor = "Sense",
                    value = "$ 12",
                    description = "During a heat wave, the last thing we want a cold brew latte bar, on the other hand, is the type of pick-me-up we crave.",
                    backgroundColor = "#79EBEE",
                    Image = "Icecream3.png"
                },
                new Popsicles()
                {
                    name = "Pink",
                    flavor = "Pallet",
                    value = "$ 10",
                    description = "During a heat wave, the last thing we want a cold brew latte bar, on the other hand, is the type of pick-me-up we crave.",
                    backgroundColor = "#FBCEDC",
                    Image = "Icecream2.png"
                },
                new Popsicles()
                {
                    name = "Tango",
                    flavor = "Mango",
                    value = "$ 10",
                    description = "During a heat wave, the last thing we want a cold brew latte bar, on the other hand, is the type of pick-me-up we crave.",
                    backgroundColor = "#FFE08E",
                    Image = "Icecream4.png"
                },
                 new Popsicles()
                {
                    name = "Mild",
                    flavor = "Lemonade",
                    value = "$ 10",
                    description = "During a heat wave, the last thing we want a cold brew latte bar, on the other hand, is the type of pick-me-up we crave.",
                    backgroundColor = "#66FFC8",
                    Image = "Icecream6.png"
                },
            };
        }
    }
}
