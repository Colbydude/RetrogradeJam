using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace RetrogradeJam.Entities.Components
{
    public class Sprite : Component
    {
        public int Width;
        public int Height;

        private Rectangle _destinationRectangle;
        private Rectangle _sourceRectangle;
        private Texture2D _texture;
        private Transform _transform;

        public Sprite(Texture2D texture, int w, int h)
        {
            SetTexture(texture);
            Width = w;
            Height = h;
        }

        public void SetTexture(Texture2D texture)
        {
            _texture = texture;
        }

        public override void Initialize()
        {
            _transform = Entity.GetComponent<Transform>();

            _sourceRectangle = new Rectangle(0, 0, Width, Height);
            _destinationRectangle = _sourceRectangle;
        }

        public override void Update(GameTime gameTime)
        {
            _destinationRectangle.X = (int) _transform.Position.X;
            _destinationRectangle.Y = (int) _transform.Position.Y;
            _destinationRectangle.Width = (int) (Width * _transform.Scale.X);
            _destinationRectangle.Height = (int) (Height * _transform.Scale.Y);
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(_texture, _destinationRectangle, _sourceRectangle, Color.White);
        }
    }
}
