using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RetrogradeJam.Entities;
using RetrogradeJam.Screens;

namespace RetrogradeJam
{
    public class Game1 : Game
    {
        private const int GRAPHICS_WIDTH = 160;
        private const int GRAPHICS_HEIGHT = 144;
        private const int WINDOW_WIDTH = 640;
        private const int WINDOW_HEIGHT = 576;

        private GraphicsDeviceManager _graphics;
        private Matrix _graphicsScale;
        private ScreenManager _screenManager;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // Set up the window.
            _graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
            _graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;
            _graphics.ApplyChanges();

            float scaleX = _graphics.PreferredBackBufferWidth / GRAPHICS_WIDTH;
            float scaleY = _graphics.PreferredBackBufferHeight / GRAPHICS_HEIGHT;

            _graphicsScale = Matrix.CreateScale(new Vector3(scaleX, scaleY, 1));

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Set up screens.
            _screenManager = new ScreenManager(Content);

            _screenManager.AddScreen(new StartScreen(new ContentManager(Content.ServiceProvider, Content.RootDirectory), _screenManager), "Start");
            _screenManager.AddScreen(new TankScreen(new ContentManager(Content.ServiceProvider, Content.RootDirectory), _screenManager), "Main");

            _screenManager.LoadScreen("Start");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) {
                Exit();
            }

            _screenManager.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin(SpriteSortMode.Immediate, null, SamplerState.PointClamp, null, null, null, _graphicsScale);

                _screenManager.Draw(_spriteBatch, gameTime);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
