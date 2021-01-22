﻿using Monocle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Mod.ShaderHelper
{
    public abstract class IEffectManager
    {
        public abstract void Apply(VirtualRenderTarget source);
    }
}