using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BumptyRun
{
    class PINEAPPLE : MovingAnimation
    {
        Vector2 speed;
        public PINEAPPLE (Texture2D image, Vector2 position, Vector2 speed, Color color, List<Rectangle> frames)
            : base (image, position, speed, color, frames)
        {
            this.speed = speed;
        }

    }
}
