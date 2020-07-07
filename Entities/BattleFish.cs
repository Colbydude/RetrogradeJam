using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using RetrogradeJam.Entities.Components;
using RetrogradeJam.Graphics;
using RetrogradeJam.Models;
using System;

namespace RetrogradeJam.Entities
{
    public class BattleFish : Entity
    {
        private Fish _data;

        private Animation swimAnimation = new Animation(0, 2, 180);

        public BattleFish(EntityManager entityManager, string entityName, Fish data) : base(entityManager, entityName)
        {
            _data = data;
        }

        public override void LoadContent(ContentManager content)
        {
            Texture2D fishTexture = content.Load<Texture2D>("Sprites/" + _data.SpriteAsset);

            AddComponent<Transform>(new Transform(new Vector2(0, 0), new Vector2(1, 1)));

            Sprite fishSprite = AddComponent<Sprite>(new Sprite(fishTexture, (int) _data.FrameSize.X, (int) _data.FrameSize.Y));
            fishSprite.AddAnimation(swimAnimation, "Swim");

            fishSprite.Play("Swim");
        }
    }
}
