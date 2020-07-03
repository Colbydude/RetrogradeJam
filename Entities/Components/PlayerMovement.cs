using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace RetrogradeJam.Entities.Components
{
    public class PlayerMovement : Component
    {
        private const float MOVE_SPEED = 30f;

        private int _direction;
        private Sprite _sprite;
        private Transform _transform;

        public override void Initialize()
        {
            _sprite = Entity.GetComponent<Sprite>();
            _transform = Entity.GetComponent<Transform>();
        }

        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float) gameTime.ElapsedGameTime.TotalSeconds;

            UpdateFacing();
            Movement(deltaTime);
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            //
        }

        private void Movement(float deltaTime)
        {
            int holdL, holdR, holdU, holdD;
            float speed;

            holdL = Keyboard.GetState().IsKeyDown(Keys.Left) ? 1 : 0;
            holdR = Keyboard.GetState().IsKeyDown(Keys.Right) ? 1 : 0;
            holdU = Keyboard.GetState().IsKeyDown(Keys.Up) ? 1 : 0;
            holdD = Keyboard.GetState().IsKeyDown(Keys.Down) ? 1 : 0;

            // Cancel opposing keys.
            if (holdL == 1 && holdR == 1) {
                holdL = 0;
                holdR = 0;
            }

            if (holdU == 1 && holdD == 1) {
                holdU = 0;
                holdD = 0;
            }

            // Adjust movement speed when moving diagonally.
            if ((holdD == 1 || holdU == 1) && (holdL == 1 || holdR == 1)) {
                speed = (MOVE_SPEED / MathF.Sqrt(2));
            } else {
                speed = MOVE_SPEED;
            }

            Vector2 moveVector = new Vector2((holdR - holdL) * speed, (holdD - holdU) * speed);

            if (moveVector != Vector2.Zero) {
                _transform.Position.X += moveVector.X * deltaTime;
                _transform.Position.Y += moveVector.Y * deltaTime;
            }

            switch (holdL + holdR + holdU + holdD) {
                case 0:
                    _sprite.Pause();
                break;
                case 1:
                    _direction = (Constants.Direction.Left) * holdL +
                                 (Constants.Direction.Up) * holdU +
                                 (Constants.Direction.Down) * holdD;
                break;
                default:
                    switch (_direction) {
                        case 180: if (holdR == 1) { _direction = Constants.Direction.Right; } break;
                        case 0: if (holdL == 1) { _direction = Constants.Direction.Left; } break;
                        case 90: if (holdD == 1) { _direction = Constants.Direction.Right; } break;
                        default: if (holdU == 1) { _direction = Constants.Direction.Up; } break;
                    }
                break;
            }
        }

        private void UpdateFacing()
        {
            switch (_direction) {
                case 180: _sprite.Play("WalkLeft"); break;
                case 0: _sprite.Play("WalkRight"); break;
                case 90: _sprite.Play("WalkUp"); break;
                default: _sprite.Play("WalkDown"); break;
            }
        }
    }
}
