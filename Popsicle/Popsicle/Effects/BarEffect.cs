using System.Linq;
using Xamarin.Forms;

namespace Popsicle.Effects
{
    public class BarEffect
    {
        public static readonly BindableProperty ColorProperty =
            BindableProperty.CreateAttached("Color", typeof(Color), typeof(BarEffect), Color.Blue, propertyChanged: OnColorChanged);

        public static Color GetColor(BindableObject view)
        {
            return (Color)view.GetValue(ColorProperty);
        }

        public static void SetColor(BindableObject view, Color value)
        {
            view.SetValue(ColorProperty, value);
        }


        static void OnColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var contentPage = bindable as ContentPage;
            if (contentPage == null)
            {
                return;
            }

            Color novaCor = (Color)newValue;

            var toRemove = contentPage.Effects.FirstOrDefault(e => e is StatusBarEffect);
            if (toRemove != null)
            {
                contentPage.Effects.Remove(toRemove);
            }

            contentPage.Effects.Add(new StatusBarEffect() { BackgroundColor = novaCor });

        }
    }
}
