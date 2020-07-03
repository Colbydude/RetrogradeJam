using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RetrogradeJam.Graphics;
using System;
using System.Collections.Generic;

namespace RetrogradeJam.Entities.Components
{
    public class Sprite : Component
    {
        public int Width;
        public int Height;

        private Dictionary<string, Animation> _animations = new Dictionary<string, Animation>();
        private float _animationTimer;
        private int _animationSpeed;
        private Animation _currentAnimation;
        private int _currentIndex;
        private Rectangle _destinationRectangle;
        private bool _isAnimating;
        private Rectangle _sourceRectangle;
        private Texture2D _texture;
        private Transform _transform;

        public Sprite(Texture2D texture, int w, int h)
        {
            SetTexture(texture);
            Width = w;
            Height = h;

            _animationTimer = 0;
            _animationSpeed = 0;
            _currentIndex = 0;
            _isAnimating = false;
        }

        public void AddAnimation(Animation animation, string animationName)
        {
            _animations.Add(animationName, animation);
        }

        public Animation GetAnimation(string animationName)
        {
            return _animations[animationName];
        }

        public void Play(string animationName, bool fromFirstFrame = false)
        {
            Animation anim = GetAnimation(animationName);

            if (_currentIndex > anim.Frames - 1 || fromFirstFrame) {
                _currentIndex = 0;
            }

            _currentAnimation = anim;
            _animationSpeed = anim.Speed;
            _isAnimating = true;
        }

        public void Pause()
        {
            _isAnimating = false;
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
            if (_isAnimating) {
                _animationTimer += (float) gameTime.ElapsedGameTime.TotalMilliseconds;

                if (_animationTimer > _currentAnimation.Speed) {
                    _animationTimer = 0;

                    _currentIndex++;

                    if (_currentIndex > _currentAnimation.Frames - 1) {
                        _currentIndex = 0;
                    }
                }

                _sourceRectangle.X = _sourceRectangle.Width * (_currentIndex + _currentAnimation.StartIndex);
            }

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
