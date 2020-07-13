using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Popsicle.Effects
{
    public class StatusBarEffect : RoutingEffect
    {
        public Color BackgroundColor { get; set; }

        public StatusBarEffect() : base("Popsicle.StatusBarEffect")
        {

        }
    }
}
