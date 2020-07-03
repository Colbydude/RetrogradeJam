using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace RetrogradeJam.Entities.Components
{
    public abstract class Component
    {
        public Entity Entity;

        public abstract void Initialize();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(SpriteBatch spriteBatch, GameTime gameTime);
    }
}
