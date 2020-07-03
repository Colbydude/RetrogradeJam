using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace RetrogradeJam.Entities.Components
{
    public class SpriteComponent : Component
    {
        public Texture2D Texture { get; private set; }
        public int Width;
        public int Height;

        private TransformComponent _transform;

        // @TODO source rectangle

        public SpriteComponent(Texture2D texture, int w, int h)
        {
            Texture = texture;
            Width = w;
            Height = h;
        }

        public override void Initialize()
        {
            _transform = Entity.GetComponent<TransformComponent>();
        }

        public override void Update(GameTime gameTime)
        {
            //
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(
                Texture, _transform.Position,
                new Rectangle((int) _transform.Position.X, (int) _transform.Position.Y, Width, Height),
                Color.White
            );
        }
    }
}
