using PluginFramework.Common;
using PluginFramework.Service.Effects;
using PluginFramework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PluginFramework.Service.Services
{
    public class ChangeImageServices : IChangeImage
    {
        private IChangeImageProperties _changeImageProperties;
        public ChangeImageServices(IChangeImageProperties changeImageProperties)
        {
            _changeImageProperties = changeImageProperties;
        }
        public Bitmap UpdateImage(WireFrameInfo wireFrameInfo)
        {
            var image = _changeImageProperties.ChangeImageProperty(wireFrameInfo.Image, new ImageProperty { Radius = wireFrameInfo.Radius, Size = wireFrameInfo.Size });
            image = SetOnlyEffect(wireFrameInfo.Effects, image);
            return image;
        }

        public List<Bitmap> UpdateImages(List<WireFrameInfo> wireFrameInfo)
        {
            List<Bitmap> images = new List<Bitmap>();
            foreach (var item in wireFrameInfo)
            {
                var image = _changeImageProperties.ChangeImageProperty(item.Image, new ImageProperty { Radius = item.Radius, Size = item.Size });
                image = SetOnlyEffect(item.Effects, image);
                images.Add(image);
            }
            return images;
        }
        private Bitmap SetOnlyEffect(List<int> effects, Bitmap image)
        {
            ImageChangeStrategyService changeStrategyService = new();
            foreach (var effect in effects)
            {
                IImageChangeStrategy effectStrategy;
                Func<Bitmap, Bitmap> strategyMethod;
                switch (effect)
                {
                    case 1:
                        strategyMethod = new Effect1(new EffectImage1()).SetEffect;
                        //effectStrategy = new Effect1(new EffectImage1());
                        break;
                    case 2:
                        strategyMethod = new Effect2(new EffectImage2()).SetEffect;
                        //effectStrategy = new Effect2(new EffectImage2());
                        break;
                    //it can be more
                    default:
                        strategyMethod = new EffectDefault(new EffectImage2()).SetEffect;
                        //effectStrategy = new EffectDefault(new EffectImage1());
                        break;
                }
                //changeStrategyService.SetStrategy(effectStrategy);
                //image = changeStrategyService.EditImage(image);
                image = changeStrategyService.EditImage(strategyMethod, image);
            }
            return image;
        }
    }
}
