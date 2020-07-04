using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace RetrogradeJam.Screens
{
    public class StartScreen : Screen
    {
        private Texture2D _logo;

        public StartScreen(ContentManager content, ScreenManager screenManager) : base(content, screenManager) { }

        public override void LoadContent()
        {
            _logo = _content.Load<Texture2D>("Sprites/JamLogo");

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Start == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Enter)) {
                _screenManager.LoadScreen("Main");
            }

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(
                _logo,
                new Rectangle(20, 43, 120, 58),
                Color.White
            );

            base.Draw(spriteBatch, gameTime);
        }
    }
}
