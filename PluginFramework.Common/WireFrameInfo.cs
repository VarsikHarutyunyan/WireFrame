using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework.Common
{
    public class WireFrameInfo
    {
        public Bitmap Image { get; set; }
        public string name { get; set; }
        public ImageSizeModel Size { get; set; }
        public double Radius { get; set; }
        public List<int> Effects { get; set; }
    }
}
