using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RetrogradeJam.Entities;

namespace RetrogradeJam
{
    public class Game1 : Game
    {
        private const int GRAPHICS_WIDTH = 160;
        private const int GRAPHICS_HEIGHT = 144;
        private const int WINDOW_WIDTH = 640;
        private const int WINDOW_HEIGHT = 576;

        private EntityManager _entityManager;
        private GraphicsDeviceManager _graphics;
        private Matrix _graphicsScale;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _entityManager = new EntityManager(_graphics);
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

            Player player = new Player(_entityManager, "player");
            _entityManager.AddEntity(player);

            _entityManager.LoadContent(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) {
                Exit();
            }

            _entityManager.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, null, _graphicsScale);

                _entityManager.Draw(_spriteBatch, gameTime);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
