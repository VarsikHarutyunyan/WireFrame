using PluginFramework.Common;
using PluginFramework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

                switch (effect)
                {
                    case 1:
                        image = changeStrategyService.EditImage(image, new EffectImage1());
                        break;
                    case 2:
                        image = changeStrategyService.EditImage(image, new EffectImage2());
                        break;
                    //it can be more
                    default:
                        break;
                }
            }
            return image;
        }
    }
}
