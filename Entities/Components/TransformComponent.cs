using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace RetrogradeJam.Entities.Components
{
    public class TransformComponent : Component
    {
        public Vector2 Position;
        public Vector2 Scale;
        public Vector2 Velocity;

        public TransformComponent(Vector2 pos, Vector2 scale, Vector2 velocity)
        {
            Position = pos;
            Scale = scale;
            Velocity = velocity;
        }

        public override void Initialize()
        {
            //
        }

        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float) gameTime.ElapsedGameTime.TotalSeconds;

            if (Velocity != Vector2.Zero) {
                Position.X += Velocity.X * deltaTime;
                Position.Y += Velocity.Y * deltaTime;
            }
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            //
        }
    }
}
