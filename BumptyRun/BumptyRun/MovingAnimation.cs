using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BumptyRun
{
    public class MovingAnimation : Animation
    {
        Vector2 speed;
        //Vector2 originalspeed;

        public MovingAnimation(Texture2D image, Vector2 position, Vector2 speed, Color color, List<Rectangle> frames)
            : base(image, position, color, frames)
        {
            this.speed = speed;
       //     originalspeed = speed;
        }

        public override void Update(GameTime gTime)
        {
            

          
            base.Update(gTime);
        }








    }
}
