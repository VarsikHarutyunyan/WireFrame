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
    public class Effect2: IImageChangeStrategy
    {
        private IEffectImage imageEffect;
        public Effect2(IEffectImage effectImage)
        {
            imageEffect = effectImage;
        }
        public Bitmap SetEffect(Bitmap image)
        {
            var data = imageEffect as EffectImage2;
            //change image 
            return image;
        }
    }
}
