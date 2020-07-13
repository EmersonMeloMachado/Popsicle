using UIKit;
using Foundation;
using System.Linq;
using Xamarin.Forms;
using Popsicle.iOS.Effects;
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
                UIView statusBar;
                if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
                {
                    int tag = 123;
                    UIWindow window = UIApplication.SharedApplication.Windows.FirstOrDefault();
                    statusBar = window.ViewWithTag(tag);
                    if (statusBar == null)
                    {
                        statusBar = new UIView(UIApplication.SharedApplication.StatusBarFrame);
                        statusBar.Tag = tag;
                    }
                     statusBar.BackgroundColor = statusBarEffect.BackgroundColor.ToUIColor();
                     window.AddSubview(statusBar);
                }
                else
                {
                    statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
                    if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
                    {
                        statusBar.BackgroundColor = statusBarEffect.BackgroundColor.ToUIColor();
                    }
                }
            }
        }

        protected override void OnDetached()
        {

        }
    }
}