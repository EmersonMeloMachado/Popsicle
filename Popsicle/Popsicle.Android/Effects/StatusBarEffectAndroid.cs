using System.Linq;
using Android.Views;
using Xamarin.Forms;
using Plugin.CurrentActivity;
using Popsicle.Droid.Effects;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Popsicle")]
[assembly: ExportEffect(typeof(StatusBarEffectAndroid), "StatusBarEffect")]
namespace Popsicle.Droid.Effects
{
    public class StatusBarEffectAndroid : PlatformEffect
    {
        protected override void OnAttached()
        {
            var statusBarEffect = (Popsicle.Effects.StatusBarEffect)Element.Effects.FirstOrDefault(e => e is Popsicle.Effects.StatusBarEffect);

            if (statusBarEffect != null)
            {
                var backgroundColor = statusBarEffect.BackgroundColor.ToAndroid();
                Window currentWindow = GetCurrentWindow();
                currentWindow.SetStatusBarColor(backgroundColor);
            }
        }

        protected override void OnDetached()
        {

        }

        Window GetCurrentWindow()
        {
            var window = CrossCurrentActivity.Current.Activity.Window;

            window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);

            return window;
        }
    }
}