﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework.Common
{
    public class EffectImage1 : IEffectImage
    {
        public Bitmap Image { get; set; }
        public int Size { get; set; }
        public int Border { get; set; }
    }
}
