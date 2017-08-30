using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace BumptyRun
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        

        Texture2D SpikyTurtleSSI;
        Vector2 SpikyTurtleAP;
        Color SpikyTurtleC;
        List<Rectangle> SpikyRedTurtleMoves;

        Texture2D GopherSSI;
        Vector2 GopherAP;
        Color GopherC;
        List<Rectangle> GopherMoves;

        Texture2D WeirdPineappleSSI;
        Vector2 WeirdPineappleAP;
        Color WeirdPineappleC;
        List<Rectangle> PineappleMoves;
        Texture2D FireBallSSI;
        Vector2 FireBallAP;
        Color FireBallC;
        List<Rectangle> FireBallMoves;

        Texture2D BumptySSI;
        Vector2 BumptyAP;
        Color BumptyC;
        List<Rectangle> BumptyMoves;

        BUMPTY Bumpty4Prez;
        FATGOPHER GopherInAHole;
        FIREBALL LavaFireBubbleThing;
        PINEAPPLE PenPineappleApplePen;
        SpikyRedTurtle SpkyRdTrtle;

        SKYFLAKER flake;
        Link LINK2;
        ChokingOnMyTongue TONGUE2;
        //new List<Rectangle>()
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()

        {
            graphics.PreferredBackBufferWidth = 500;
            graphics.PreferredBackBufferHeight = 500;
            graphics.ApplyChanges();
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            FireBallSSI = Content.Load<Texture2D>("Fireball");
            FireBallAP = new Vector2(100, 5);
            FireBallC = Color.White;
            FireBallMoves = new List<Rectangle>();
            FireBallMoves.Add(new Rectangle(35, 51, 27, 44));

            FireBallMoves.Add(new Rectangle(66, 50, 28, 45));

            FireBallMoves.Add(new Rectangle(98, 51, 28, 44));
         
            FireBallMoves.Add(new Rectangle(131, 49, 27, 46));
         /*
            FireBallMoves.Add(new Rectangle(195, 1, 27, 46));
            
            FireBallMoves.Add(new Rectangle(2, 51, 28, 44));
        
            FireBallMoves.Add(new Rectangle(163, 51, 27, 44));
    */
            FireBallMoves.Add(new Rectangle(35, 51, 27, 44));

            FireBallMoves.Add(new Rectangle(66, 50, 28, 45));

            FireBallMoves.Add(new Rectangle(98, 51, 28, 44));

            FireBallMoves.Add(new Rectangle(131, 49, 27, 46));
 /*
            FireBallMoves.Add(new Rectangle(195, 1, 27, 46));
            
            FireBallMoves.Add(new Rectangle(2, 51, 28, 44));

            FireBallMoves.Add(new Rectangle(163, 51, 27, 44));
   */   
            FireBallMoves.Add(new Rectangle(35, 51, 27, 44));
           
            FireBallMoves.Add(new Rectangle(66, 50, 28, 45));
       
            FireBallMoves.Add(new Rectangle(98, 51, 28, 44));
            
            FireBallMoves.Add(new Rectangle(131, 49, 27, 46));
     /*    
            FireBallMoves.Add(new Rectangle(195, 1, 27, 46));
         
            FireBallMoves.Add(new Rectangle(2, 51, 28, 44));
        
            FireBallMoves.Add(new Rectangle(163, 51, 27, 44));
       */
            FireBallMoves.Add(new Rectangle(35, 51, 27, 44));
           
            FireBallMoves.Add(new Rectangle(66, 50, 28, 45));
         
            FireBallMoves.Add(new Rectangle(98, 51, 28, 44));
        
            FireBallMoves.Add(new Rectangle(131, 49, 27, 46));
       /*
            FireBallMoves.Add(new Rectangle(195, 1, 27, 46));
           
            FireBallMoves.Add(new Rectangle(2, 51, 28, 44));
        
            FireBallMoves.Add(new Rectangle(163, 51, 27, 44));
       */
            FireBallMoves.Add(new Rectangle(35, 51, 27, 44));
      
            FireBallMoves.Add(new Rectangle(66, 50, 28, 45));
          
            FireBallMoves.Add(new Rectangle(98, 51, 28, 44));
       
            FireBallMoves.Add(new Rectangle(131, 49, 27, 46));
         /* 
            FireBallMoves.Add(new Rectangle(195, 1, 27, 46));
 
            FireBallMoves.Add(new Rectangle(2, 51, 28, 44));
            
            FireBallMoves.Add(new Rectangle(163, 51, 27, 44));
        */

            LavaFireBubbleThing = new FIREBALL(FireBallSSI, FireBallAP, new Vector2(1), FireBallC, FireBallMoves);

            WeirdPineappleSSI = Content.Load<Texture2D>("pen pineapple apple pen");
            WeirdPineappleAP = new Vector2(130, 8);
            WeirdPineappleC = Color.White;
            PineappleMoves = new List<Rectangle>();
           PineappleMoves.Add(new Rectangle(194, 163, 44, 36));
            PineappleMoves.Add(new Rectangle(196, 114, 40, 37));
            PineappleMoves.Add(new Rectangle(197, 209, 38, 38));
          //  PineappleMoves.Add(new Rectangle(14, 111, 40, 40));
            PineappleMoves.Add(new Rectangle(197, 209, 38, 38));
            PineappleMoves.Add(new Rectangle(196, 114, 40, 37));
            PenPineappleApplePen = new PINEAPPLE(WeirdPineappleSSI, WeirdPineappleAP, new Vector2(1), WeirdPineappleC, PineappleMoves);

         


            SpikyTurtleSSI = Content.Load<Texture2D>("SpkyRdTrtle");
            SpikyTurtleAP = new Vector2(4, 50);
            SpikyTurtleC = Color.White;
            SpikyRedTurtleMoves = new List<Rectangle>();
            SpikyRedTurtleMoves.Add(new Rectangle(1, 125, 29, 34));
         //   SpikyRedTurtleMoves.Add(new Rectangle(1, 125, 29, 34));
            SpikyRedTurtleMoves.Add(new Rectangle(9, 49, 32, 30));
          //  SpikyRedTurtleMoves.Add(new Rectangle(9, 49, 32, 30));
            SpikyRedTurtleMoves.Add(new Rectangle(1, 6, 36, 33));
           SpikyRedTurtleMoves.Add(new Rectangle(1, 6, 36, 33));
        //    SpikyRedTurtleMoves.Add(new Rectangle(8, 243, 33, 28));
         //   SpikyRedTurtleMoves.Add(new Rectangle(8, 243, 33, 28));
            SpikyRedTurtleMoves.Add(new Rectangle(1, 6, 36, 33));
          //  SpikyRedTurtleMoves.Add(new Rectangle(1, 6, 36, 33));
            SpikyRedTurtleMoves.Add(new Rectangle(9, 49, 32, 30));
           // SpikyRedTurtleMoves.Add(new Rectangle(9, 49, 32, 30));
            SpkyRdTrtle = new SpikyRedTurtle(SpikyTurtleSSI, SpikyTurtleAP, new Vector2(1), SpikyTurtleC, SpikyRedTurtleMoves);

            BumptySSI = Content.Load<Texture2D>("BumptyRun");
            BumptyAP = new Vector2(4, 8);
            BumptyC = Color.White;
            BumptyMoves = new List<Rectangle>();
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));          
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            BumptyMoves.Add(new Rectangle(80, 52, 35, 35));
            BumptyMoves.Add(new Rectangle(122, 4, 36, 35));
            BumptyMoves.Add(new Rectangle(127, 53, 36, 34));
            
            BumptyMoves.Add(new Rectangle(75, 4, 40, 35));
            BumptyMoves.Add(new Rectangle(75, 4, 40, 35));
            BumptyMoves.Add(new Rectangle(75, 4, 40, 35));
            BumptyMoves.Add(new Rectangle(75, 4, 40, 35));
            BumptyMoves.Add(new Rectangle(75, 4, 40, 35));
            BumptyMoves.Add(new Rectangle(75, 4, 40, 35));
            
            Bumpty4Prez = new BUMPTY(BumptySSI, BumptyAP, new Vector2(1), BumptyC, BumptyMoves);
            
            GopherSSI = Content.Load<Texture2D>("FatGopher");
            GopherAP = new Vector2(50, 10);
            GopherC = Color.White;
            GopherMoves = new List<Rectangle>();
            GopherMoves.Add(new Rectangle(49, 127, 44, 32));
            GopherMoves.Add(new Rectangle(273, 127, 44, 32));
            GopherMoves.Add(new Rectangle(273, 127, 44, 32));
            GopherMoves.Add(new Rectangle(273, 127, 44, 32));
            GopherMoves.Add(new Rectangle(273, 127, 44, 32));
                 GopherMoves.Add(new Rectangle(273, 127, 44, 32));
            GopherMoves.Add(new Rectangle(49, 127, 44, 32));
            GopherMoves.Add(new Rectangle(1, 127, 44, 32));
            GopherMoves.Add(new Rectangle(145, 127, 44, 32));
            GopherMoves.Add(new Rectangle(1, 127, 44, 32));
            GopherMoves.Add(new Rectangle(145, 127, 44, 32));
            GopherMoves.Add(new Rectangle(1, 127, 44, 32));
            GopherMoves.Add(new Rectangle(145, 127, 44, 32));
            GopherMoves.Add(new Rectangle(1, 127, 44, 32));
            GopherMoves.Add(new Rectangle(145, 127, 44, 32));
            GopherMoves.Add(new Rectangle(1, 127, 44, 32));
            GopherMoves.Add(new Rectangle(145, 127, 44, 32));
            GopherMoves.Add(new Rectangle(1, 127, 44, 32));
            GopherMoves.Add(new Rectangle(145, 127, 44, 32));
            GopherMoves.Add(new Rectangle(1, 127, 44, 32));
            GopherMoves.Add(new Rectangle(145, 127, 44, 32));
            GopherMoves.Add(new Rectangle(1, 127, 44, 32));
            GopherMoves.Add(new Rectangle(145, 127, 44, 32));
            GopherMoves.Add(new Rectangle(1, 127, 44, 32));
            GopherMoves.Add(new Rectangle(145, 127, 44, 32));
            GopherMoves.Add(new Rectangle(1, 127, 44, 32));
            GopherMoves.Add(new Rectangle(145, 127, 44, 32));
            GopherMoves.Add(new Rectangle(1, 127, 44, 32));
            GopherMoves.Add(new Rectangle(49, 127, 44, 32));
     
            GopherInAHole = new FATGOPHER(GopherSSI, GopherAP, new Vector2(1), GopherC, GopherMoves);
            //GET NEW BUMPTY FROM SPRITERS RESOURCE - THE OLD ONE IS MESSED UP

            LINK2 = new Link(Content.Load<Texture2D>("L!NK"), new Vector2(300), new Vector2(1), Color.White, new List<Rectangle>());
            TONGUE2 = new ChokingOnMyTongue(Content.Load<Texture2D>("T#NGUE"), new Vector2(200), new Vector2(1), Color.White, new List<Rectangle>());
            flake = new SKYFLAKER(Content.Load<Texture2D>("LUK"), new Vector2(100), new Vector2(1), Color.White, new List<Rectangle>());
            // TODO: use this.Content to load your game conten graphics.PreferredBackBufferWidth = 1800;t here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            KeyboardState ks = Keyboard.GetState();
            // TODO: Add your update logic here

            Bumpty4Prez.Update(gameTime);
            GopherInAHole.Update(gameTime);
            LavaFireBubbleThing.Update(gameTime);
            PenPineappleApplePen.Update(gameTime);
            SpkyRdTrtle.Update(gameTime);
            flake.Update(gameTime, ks);
            LINK2.Update(gameTime, ks);
            TONGUE2.Update(gameTime, ks);

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            
            GraphicsDevice.Clear(Color.Lerp(Color.LawnGreen, Color.Chartreuse, .5f));
          //  GraphicsDevice.Clear(Color.Chartreuse);
            //SpringGreen and Chartreuse
            //Chartreuse and LawnGreen
            // TODO: Add your drawing code here
            Bumpty4Prez.Draw(spriteBatch);
            GopherInAHole.Draw(spriteBatch);
            LavaFireBubbleThing.Draw(spriteBatch);
            PenPineappleApplePen.Draw(spriteBatch);
            SpkyRdTrtle.Draw(spriteBatch);
            flake.Draw(spriteBatch);
                    LINK2.Draw(spriteBatch);
            TONGUE2.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
