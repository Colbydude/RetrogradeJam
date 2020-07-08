using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace RetrogradeJam.Screens
{
    public class ScreenManager
    {
        private ContentManager _content;
        private Screen _currentScreen;
        private Dictionary<string, Screen> _screens = new Dictionary<string, Screen>();

        public ScreenManager(ContentManager content)
        {
            _content = content;
        }

        public void AddScreen(Screen screen, string screenName)
        {
            _screens.Add(screenName, screen);
        }

        public Screen GetScreen(string screenName)
        {
            return _screens[screenName];
        }

        public void LoadScreen(string screenName)
        {
            if (_currentScreen != null) {
                _currentScreen.UnloadContent();
            }

            _currentScreen = GetScreen(screenName);
            _currentScreen.Initialize();
            _currentScreen.LoadContent();
        }

        public void Update(GameTime gameTime)
        {
            _currentScreen.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            _currentScreen.Draw(spriteBatch, gameTime);
        }
    }
}
