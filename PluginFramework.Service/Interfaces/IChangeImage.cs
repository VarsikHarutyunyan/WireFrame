using PluginFramework.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework.Service.Interfaces
{
    public interface IChangeImage
    {
        Bitmap UpdateImage(WireFrameInfo wireFrameInfo);
        List<Bitmap> UpdateImages(List<WireFrameInfo> wireFrameInfo);
    }
}
