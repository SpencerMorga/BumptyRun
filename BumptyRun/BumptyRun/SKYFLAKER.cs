using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BumptyRun
{
    class SKYFLAKER : MovingAnimation 

    {
        Dictionary<Enums.SKYFLAKYNESS, List<Rectangle>> animashun;
        private Enums.SKYFLAKYNESS FlakeState;
        Enums.SKYFLAKYNESS currentFlakeState
        {
            get
            {
                return FlakeState;
            }
            set
            {
                if (FlakeState != value)
                {
                    FlakeState = value;
                    currentframenumindex = 0;
                }
            }
        }
        public  SKYFLAKER(Texture2D image, Vector2 position, Vector2 speed, Color color, List<Rectangle> frames)
            : base (image, position, speed, color, frames)
        {
            List<Rectangle> StandingFlake = new List<Rectangle>()
            {
                new Rectangle(2, 137, 20, 37),
                new Rectangle(23 ,137, 18 ,37),
            };
            animashun = new Dictionary<Enums.SKYFLAKYNESS, List<Rectangle>>();
            animashun.Add(Enums.SKYFLAKYNESS.Idle, StandingFlake);

            List<Rectangle> HOYEEAH = new List<Rectangle>()
            {
                new Rectangle(2, 213, 20, 48),
                new Rectangle(25, 212, 24, 48),
                new Rectangle(51, 212, 24, 49),
                new Rectangle(77, 212, 36, 49),
            };
            animashun.Add(Enums.SKYFLAKYNESS.Slash, HOYEEAH);
            currentFlakeState = Enums.SKYFLAKYNESS.Idle;
            this.frames = animashun[currentFlakeState];
        }
        public void Update(GameTime gTime, KeyboardState ks)
        {
            frames = animashun[currentFlakeState];
            if (currentFlakeState == Enums.SKYFLAKYNESS.Slash)
            {
                if (currentframenumindex + 1 >= frames.Count)
                {
                    currentFlakeState = Enums.SKYFLAKYNESS.Idle;
                }
            }
            if (ks.IsKeyDown(Keys.L))
            {
                currentFlakeState = Enums.SKYFLAKYNESS.Slash;
            }
            base.Update(gTime);
        }












    }
}
