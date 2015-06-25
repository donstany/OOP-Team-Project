namespace TestMonogame
{
    using System.Text;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private const int WindowWidth = 1280;
        private const int WindowHeight = 720;
        private const string windowTitle = "Allied Tion OOP Teamwork Test Application";

        private readonly int currentScreenWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
        private readonly int currentScreenHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Texture2D heroSkin;
        private Texture2D map;

        private SpriteFont spriteFont;

        private Player player;
        private Vector2 mapPosition;

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
            //window settings
            this.graphics.PreferredBackBufferWidth = WindowWidth;
            this.graphics.PreferredBackBufferHeight = WindowHeight;
            this.Window.Title = windowTitle;

            this.Window.Position = new Point((currentScreenWidth - WindowWidth) / 2,
                (currentScreenHeight - WindowHeight) / 2);

            //this.graphics.ToggleFullScreen();

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

            this.heroSkin = Content.Load<Texture2D>("HeroSkin");
            this.map = Content.Load<Texture2D>("map");
            spriteFont = Content.Load<SpriteFont>("SpriteFont");

            player = new Player("ivancho", 1, 1, heroSkin);
            mapPosition = new Vector2(0, 0);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                if (player.X < WindowWidth / 2
                    || mapPosition.X + map.Width < WindowWidth)
                {
                    if (player.X < WindowWidth - player.Skin.Width)
                    {
                        player.X += 3;
                    }
                }
                else
                {
                    mapPosition.X -= 3;
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                if (player.X >= WindowWidth / 2
                    || mapPosition.X >= map.Bounds.Left)
                {
                    if (player.X > 0)
                    {
                        player.X -= 3;
                    }
                }
                else
                {
                    mapPosition.X += 3;
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                if (player.Y < WindowHeight / 2
                    || mapPosition.Y + map.Height < WindowHeight)
                {
                    if (player.Y < WindowHeight - player.Skin.Height)
                    {
                        player.Y += 3;
                    }
                }
                else
                {
                    mapPosition.Y -= 3;
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                if (player.Y >= WindowHeight / 2
                    || mapPosition.Y >= map.Bounds.Top)
                {
                    if (player.Y > 0)
                    {
                        player.Y -= 3;
                    }
                }
                else
                {
                    mapPosition.Y += 3;
                }
            }


            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Gray);

            spriteBatch.Begin();

            spriteBatch.Draw(map, mapPosition, null, Color.Beige);
            //spriteBatch.Draw(map, mapPosition, null, Color.Beige, 0.0f, new Vector2(0.0f), new Vector2(1f), SpriteEffects.None, 1.0f);
            spriteBatch.Draw(player.Skin, new Vector2(player.X, player.Y));
            spriteBatch.DrawString(spriteFont, new StringBuilder("This is bolded test text"), new Vector2(100, 50), Color.WhiteSmoke);

            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

