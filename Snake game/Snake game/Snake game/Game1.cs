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

namespace Snake_game
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Vector2 pellet = new Vector2(2, 2);
        List<Vector2> Snake = new List<Vector2>();
        Texture2D snakeTexture;
        Vector2 velocity = new Vector2(0, -1);
        Vector2 location = new Vector2(1, 1);
        
        

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
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Snake.Add(new Vector2(40,24));
            snakeTexture = Content.Load<Texture2D>(@"snake");
            

            // TODO: use this.Content to load your game content here
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
           
            // TODO: Add your update logic here

             KeyboardState kb = Keyboard.GetState();
            if(kb.IsKeyDown(Keys.Up))
            {
                velocity = new Vector2 (0,-1);
            }
             if(kb.IsKeyDown(Keys.Down))
            {
                velocity = new Vector2 (0,1);
            }
             if(kb.IsKeyDown(Keys.Left))
            {
                velocity = new Vector2 (1,0);
            }
             if(kb.IsKeyDown(Keys.Right))
            {
                velocity = new Vector2(-1, 0);
            }

            if(Snake[0] == pellet)
            {

            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Draw(snakeTexture, Snake[0] * 10, Color.Black);
             
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
