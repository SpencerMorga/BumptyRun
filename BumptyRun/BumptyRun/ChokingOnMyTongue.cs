using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BumptyRun
{
    class ChokingOnMyTongue : MovingAnimation
    {

        Dictionary<Enums.ChokingOnMyTongue2, List<Rectangle>> animation2;
        private Enums.ChokingOnMyTongue2 TongueState;
        Enums.ChokingOnMyTongue2 currentBooState
        {
            get
            {
                return TongueState;
            }
            set
            {
                if (TongueState != value)
                {
                    TongueState = value;
                    currentframenumindex = 0;
                }
            }


        }
        public ChokingOnMyTongue(Texture2D image, Vector2 position, Vector2 speed, Color color, List<Rectangle> frames)
            : base (image, position, speed, color, frames)
        {
            List<Rectangle> FlappingFrames = new List<Rectangle>()
            {
                new Rectangle(149, 4, 39, 34),
                new Rectangle(101, 100, 40, 34),
                new Rectangle(53, 100, 40, 34),
                new Rectangle(5, 100, 40, 34),
                new Rectangle(197, 4, 38, 34),
                new Rectangle(5, 100, 40, 34),
                new Rectangle(53, 100, 38, 34),
                new Rectangle(101, 100, 40, 34),
            };
            animation2 = new Dictionary<Enums.ChokingOnMyTongue2, List<Rectangle>>();
            animation2.Add(Enums.ChokingOnMyTongue2.Flapping, FlappingFrames);

            List<Rectangle> TongueFlickFrames = new List<Rectangle>()
            {
                new Rectangle(101, 148, 39, 34),
                new Rectangle(101, 196, 38, 35),
                new Rectangle(5, 194, 40, 43),
                new Rectangle(53, 193, 41, 45),
                new Rectangle(5, 194, 40, 43),
                new Rectangle(101, 196, 38, 35),
            };
            animation2.Add(Enums.ChokingOnMyTongue2.TongueFlap, TongueFlickFrames);
            currentBooState = Enums.ChokingOnMyTongue2.Flapping;
            this.frames = animation2[currentBooState];
        }
        public void Update(GameTime gTime, KeyboardState ks)
        {
            frames = animation2[currentBooState];
            if (currentBooState == Enums.ChokingOnMyTongue2.TongueFlap)
            {
                if (currentframenumindex + 1 >= frames.Count)
                {
                    currentBooState = Enums.ChokingOnMyTongue2.Flapping;
                }

            }
            if (ks.IsKeyDown(Keys.P))
            {
                currentBooState = Enums.ChokingOnMyTongue2.TongueFlap;
            }
            base.Update(gTime); 
        }
    }
}
