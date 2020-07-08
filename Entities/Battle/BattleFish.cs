using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using RetrogradeJam.Entities.Components;
using RetrogradeJam.Assets;
using RetrogradeJam.Data;

namespace RetrogradeJam.Entities.Battle
{
    public class BattleFish : Entity
    {
        private FishType _fishType;
        private Vector2 _position;
        private SpriteAsset _spriteAsset;

        public BattleFish(EntityManager entityManager, string entityName, FishType fishType) : base(entityManager, entityName)
        {
            _fishType = fishType;

            _spriteAsset = FishData.FishSpriteAssets[_fishType];
        }

        public override void LoadContent(ContentManager content)
        {
            AddComponent<Transform>(new Transform(new Vector2(0, 0), new Vector2(1, 1)));

            Texture2D fishTexture = content.Load<Texture2D>(_spriteAsset.FileName);
            Sprite fishSprite = AddComponent<Sprite>(new Sprite(fishTexture, (int) _spriteAsset.FrameSize.X, (int) _spriteAsset.FrameSize.Y));

            fishSprite.AddAnimation(_spriteAsset.Animations["Swim"], "Swim");

            fishSprite.Play("Swim");
        }
    }
}
