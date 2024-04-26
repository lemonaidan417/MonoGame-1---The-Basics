using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_1___The_Basics
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D backgroundTexture;
        Texture2D thebebopTexture;
        Texture2D thebebopminiTexture;
        Texture2D gundamstrikeTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferWidth = 634; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 472; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions

            this.Window.Title = "Sci-Fi Battle";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            backgroundTexture = Content.Load<Texture2D>("cowboy-bebop-background");
            thebebopTexture = Content.Load<Texture2D>("thebebop");
            thebebopminiTexture = Content.Load<Texture2D>("thebebopmini");
            gundamstrikeTexture = Content.Load<Texture2D>("gundam-strike");


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkOliveGreen);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(backgroundTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(thebebopTexture, new Rectangle(100, 200, 300, 200), Color.White);
            _spriteBatch.Draw(thebebopminiTexture, new Vector2(425, 225), Color.White);
            _spriteBatch.Draw(gundamstrikeTexture, new Rectangle(400, 250, 190, 190), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}