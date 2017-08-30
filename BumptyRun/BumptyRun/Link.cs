using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BumptyRun
{
    class Link : MovingAnimation
    { 

        Dictionary<Enums.ThingsLinkCanDo, List<Rectangle>> animations;
        private Enums.ThingsLinkCanDo linkState;
        Enums.ThingsLinkCanDo currentLinkState
        { 
            get
            {
                return linkState;
            }
            set
            {
                if (linkState != value)
                {
                    linkState = value;
                    currentframenumindex = 0;
                }
            }
        }
        //bool isFinished;
        
        public Link(Texture2D image, Vector2 position, Vector2 speed, Color color, List<Rectangle> frames)
            : base (image, position, speed, color, frames)
        {
            
            
            List<Rectangle> standingFrames = new List<Rectangle>()
            {
                new Rectangle(5, 140, 33, 45  ),
                new Rectangle(43, 140, 34, 45 ),
                new Rectangle(5, 140, 35, 45  ),
                new Rectangle(130, 140, 33, 45),
            };

            animations = new Dictionary<Enums.ThingsLinkCanDo, List<Rectangle>>();

            animations.Add(Enums.ThingsLinkCanDo.Idle, standingFrames); // < do this for each one

            
            List<Rectangle> crouchingFrames = new List<Rectangle>();
            {
                new Rectangle(5, 233, 33, 45);
                new Rectangle(42, 233, 35, 45);
                new Rectangle(84, 233, 38, 45);
                new Rectangle(126, 233, 38, 45);
            };

            animations.Add(Enums.ThingsLinkCanDo.Crouch, crouchingFrames);

            
            List<Rectangle> whachaFrames = new List<Rectangle>()
            {
                new Rectangle(8, 476, 44, 37),
                new Rectangle(59, 475, 45, 36),
                new Rectangle(117, 473, 71, 38),
                new Rectangle(196, 463, 63, 48),
                new Rectangle(264, 462, 64, 49),
                new Rectangle(335, 463, 63, 43),
                new Rectangle(404, 467, 61, 44),
            };
            animations.Add(Enums.ThingsLinkCanDo.UpwardSlash, whachaFrames);
            
            List<Rectangle> hoyeahFrames = new List<Rectangle>()
            {
                new Rectangle(5, 403, 43, 53),
                new Rectangle(52, 409, 48, 47),
                new Rectangle(106, 409, 40, 47),
                new Rectangle(150, 409, 76, 47),
                new Rectangle(229, 419, 74, 37),
                new Rectangle(307, 420, 48, 38),
            };
            animations.Add(Enums.ThingsLinkCanDo.DownwardSlash, hoyeahFrames);
           
            List<Rectangle> hiyahFrames = new List<Rectangle>()
            {
                new Rectangle(3, 517, 47, 42),
                new Rectangle(54, 518, 42, 41),
                new Rectangle(105, 519, 46, 40),
                new Rectangle(158, 518, 76, 41),
                new Rectangle(240, 518, 77, 41),
                new Rectangle(324, 518, 76, 41),
                new Rectangle(407, 518, 74, 41),
                new Rectangle(491, 520, 63, 39),
            };
            animations.Add(Enums.ThingsLinkCanDo.Jab, hiyahFrames);
           
            List<Rectangle> whahohiyeaaaaaahhFrames = new List<Rectangle>();
            foreach(Rectangle frame in whachaFrames)
            {
                whahohiyeaaaaaahhFrames.Add(frame);
            }
            foreach(Rectangle frame in hoyeahFrames)
            {
                whahohiyeaaaaaahhFrames.Add(frame);
            }
            foreach(Rectangle frame in hiyahFrames)
            {
                whahohiyeaaaaaahhFrames.Add(frame);
            }
            animations.Add(Enums.ThingsLinkCanDo.Combo, whahohiyeaaaaaahhFrames);
            currentLinkState = Enums.ThingsLinkCanDo.Idle;
            this.frames = animations[currentLinkState];
        }

        public  void Update(GameTime gameTime,KeyboardState ks)
        {
            
            frames = animations[currentLinkState];
            if (currentLinkState == Enums.ThingsLinkCanDo.Jab)
            {
                if(currentframenumindex + 1 >= frames.Count)
                {
                    currentLinkState = Enums.ThingsLinkCanDo.Idle;
                }
            }


            if (ks.IsKeyDown(Keys.B))
            {
               
                currentLinkState = Enums.ThingsLinkCanDo.Jab;
                

            }
            if (currentLinkState == Enums.ThingsLinkCanDo.UpwardSlash)
            {
                if (currentframenumindex + 1 >= frames.Count)
                {
                    currentLinkState = Enums.ThingsLinkCanDo.Idle;
                }
            }         
            if (ks.IsKeyDown(Keys.V))
            {
                currentLinkState = Enums.ThingsLinkCanDo.UpwardSlash;
            }     
            if (currentLinkState == Enums.ThingsLinkCanDo.DownwardSlash)
            {
                if (currentframenumindex + 1 >= frames.Count)
                {
                    currentLinkState = Enums.ThingsLinkCanDo.Idle;

                }
            }
            if (ks.IsKeyDown(Keys.C))
            {
                currentLinkState = Enums.ThingsLinkCanDo.DownwardSlash;
            }
           
            if (currentLinkState == Enums.ThingsLinkCanDo.Combo)
            {
                if (currentframenumindex + 1 >= frames.Count)
                {
                    currentLinkState = Enums.ThingsLinkCanDo.Idle;

                }
            }
            if (ks.IsKeyDown(Keys.N))
            {
                currentLinkState = Enums.ThingsLinkCanDo.Combo;
            }
         
            if (currentLinkState == Enums.ThingsLinkCanDo.Crouch)
            {
                if (currentframenumindex + 1 >= frames.Count)
                {
                    currentLinkState = Enums.ThingsLinkCanDo.Idle;
                }
            }
            if (ks.IsKeyDown(Keys.M))
            {
                currentLinkState = Enums.ThingsLinkCanDo.Crouch;
            }
              base.Update(gameTime);
        }

    }
}
