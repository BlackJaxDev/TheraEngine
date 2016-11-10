using System;
using System.Collections.Generic;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using CustomEngine.Rendering.Models.Materials;
using CustomEngine.Rendering.Models;
using CustomEngine.Worlds;

namespace CustomEngine.Rendering.HUD
{
    public class ModelHudComponent : RenderableHudComponent
    {
        public ModelHudComponent(HudComponent owner) : base(owner) { }

        Model model;
    }
}
