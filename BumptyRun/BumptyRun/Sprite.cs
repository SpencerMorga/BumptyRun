using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BumptyRun
{
    public class Sprite
    {
        // public Tex2D image Vec2 position Color color, Rec Hitbox
        public Texture2D image;
        public Vector2 position;
        public Color color;
        public Rectangle hitbox;
        //make constuctor (hitbox is debatable)
        public Sprite (Texture2D image, Vector2 position, Color color)
        {
            this.image = image;
            this.position = position;
            this.color = color;
        }
    }
}
