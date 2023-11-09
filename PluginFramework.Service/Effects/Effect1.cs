using PluginFramework.Common;
using PluginFramework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework.Service.Effects
{
    public class Effect1 : IImageChangeStrategy
    {
        public Bitmap SetEffect(Bitmap image, object effectImage)
        {
            var data = effectImage as EffectImage2;
            //change image 
            return image;
        }
    }
}
