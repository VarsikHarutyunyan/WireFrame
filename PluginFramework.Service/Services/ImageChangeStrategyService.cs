using PluginFramework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework.Service.Services
{
    public class ImageChangeStrategyService
    {
        private IImageChangeStrategy _strategy;
        public ImageChangeStrategyService() { }
        public ImageChangeStrategyService(IImageChangeStrategy strategy) { 
        _strategy = strategy;
        
        }
        public void SetStrategy(IImageChangeStrategy strategy)
        {
            this._strategy = strategy;
        }
        public Bitmap EditImage(Bitmap image, object effect)
        {
            var result = this._strategy.SetEffect(image, effect);
            return result;

        }
     }
}
