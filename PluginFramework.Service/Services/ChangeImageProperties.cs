using PluginFramework.Common;
using PluginFramework.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework.Service.Services
{
    public class ChangeImageProperties : IChangeImageProperties
    {
        public Bitmap ChangeImageProperty(Bitmap bitmap, ImageProperty imageProperty)
        {
            //do changes
            return bitmap;
        }
    }
}
