using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace RetrogradeJam.Entities.Components
{
    public class Transform : Component
    {
        public Vector2 Position;
        public Vector2 Scale;

        public Transform(Vector2 pos, Vector2 scale)
        {
            Position = pos;
            Scale = scale;
        }

        public override void Initialize()
        {
            //
        }

        public override void Update(GameTime gameTime)
        {
            //
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            //
        }
    }
}
