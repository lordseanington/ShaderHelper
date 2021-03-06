﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Celeste.Mod.ShaderHelper
{
    [CustomEntity("ShaderHelper/AddEffectTrigger")]
    public class AddEffectTrigger : Trigger
    {
        protected string shaderName;

        public AddEffectTrigger(EntityData data, Vector2 offset) : base(data, offset)
        {
            shaderName = data.Attr("shaders");
        }

        public override void OnEnter(Player player)
        {
            ShaderHelperModule.Instance.AddEffect(shaderName);
            RemoveSelf();
        }
    }
}
