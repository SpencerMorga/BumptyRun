using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace BumptyRun
{
    public class Animation : Sprite
    {
        TimeSpan elaspedTime;
        public TimeSpan Time2Wait = new TimeSpan(0, 0, 0, 0, 100);
        protected List<Rectangle> frames;
        public int currentframenumindex = 0;
        public Animation (Texture2D image, Vector2 position, Color color, List<Rectangle> frames)
            : base (image, position, color)
        {
            this.image = image;
            this.position = position;
            this.color = color;
            this.frames = frames;
            elaspedTime = TimeSpan.Zero;
        }
        public virtual void Update(GameTime gTime)
        {
            elaspedTime += gTime.ElapsedGameTime;
            if (elaspedTime > Time2Wait)
            {
                currentframenumindex++;
                if (currentframenumindex >= frames.Count)
                {
                    currentframenumindex = 0;
                }
                elaspedTime = TimeSpan.Zero;

            }
            hitbox = new Rectangle((int)position.X, (int)position.Y, frames[currentframenumindex].Width, frames[currentframenumindex].Height);
        }
        public virtual void Draw(SpriteBatch sb)
        {
            sb.Draw(image, position, frames[currentframenumindex], color);
        }

    }
}
