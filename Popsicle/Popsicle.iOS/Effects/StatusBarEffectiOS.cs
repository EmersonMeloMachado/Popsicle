using System.Linq;
using Foundation;
using Popsicle.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("Popsicle")]
[assembly: ExportEffect(typeof(StatusBarEffectiOS), "StatusBarEffect")]
namespace Popsicle.iOS.Effects
{
    public class StatusBarEffectiOS : PlatformEffect
    {
        protected override void OnAttached()
        {
            var statusBarEffect = (Popsicle.Effects.StatusBarEffect)Element.Effects.FirstOrDefault(e => e is Popsicle.Effects.StatusBarEffect);

            if (statusBarEffect != null)
            {
                UIView statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
                if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
                {
                    statusBar.BackgroundColor = statusBarEffect.BackgroundColor.ToUIColor();
                }
            }
        }

        protected override void OnDetached()
        {

        }
    }
}