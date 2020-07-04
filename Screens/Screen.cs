using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using RetrogradeJam.Entities;
using System;

namespace RetrogradeJam.Screens
{
    public class Screen
    {
        protected ContentManager _content;
        protected EntityManager _entityManager = new EntityManager();
        protected ScreenManager _screenManager;

        public Screen(ContentManager content, ScreenManager screenManager)
        {
            _content = content;
            _screenManager = screenManager;
        }

        public virtual void LoadContent()
        {
            _entityManager.LoadContent(_content);
        }

        public virtual void UnloadContent()
        {
            _entityManager.UnloadContent(_content);

            _content.Unload();
        }

        public virtual void Update(GameTime gameTime)
        {
            _entityManager.Update(gameTime);
        }

        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            _entityManager.Draw(spriteBatch, gameTime);
        }
    }
}
