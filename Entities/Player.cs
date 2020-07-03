using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using RetrogradeJam.Entities.Components;
using RetrogradeJam.Graphics;
using System;

namespace RetrogradeJam.Entities
{
    public class Player : Entity
    {
        public Player(EntityManager manager, string entityName) : base(manager, entityName)
        {
            //
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void LoadContent(ContentManager content)
        {
            AddComponent(new Transform(new Vector2(5, 5), new Vector2(1, 1)));

            Texture2D playerSheet = content.Load<Texture2D>("Sprites/MC-Sheet");
            Sprite playerSprite = AddComponent(new Sprite(playerSheet, 16, 16));
                playerSprite.AddAnimation(new Animation(0, 2), "WalkDown");
                playerSprite.AddAnimation(new Animation(2, 2), "WalkUp");
                playerSprite.AddAnimation(new Animation(4, 2), "WalkLeft");
                playerSprite.AddAnimation(new Animation(6, 2), "WalkRight");

            AddComponent(new PlayerMovement());
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            base.Draw(spriteBatch, gameTime);
        }
    }
}
