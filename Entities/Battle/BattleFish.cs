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
        // Private properties.
        private FishType _fishType;
        private bool _flipped;
        private SpriteAsset _spriteAsset;

        // Component references.
        private Sprite _sprite;
        private Transform _transform;

        public BattleFish(EntityManager entityManager, string entityName, FishType fishType, bool flipped = false) : base(entityManager, entityName)
        {
            _fishType = fishType;
            _flipped = flipped;

            _spriteAsset = FishData.FishSpriteAssets[_fishType];
        }

        public override void LoadContent(ContentManager content)
        {
            _transform = AddComponent<Transform>(new Transform(new Vector2(0, 0), new Vector2(1, 1)));

            Texture2D fishTexture = content.Load<Texture2D>(_spriteAsset.FileName);
            _sprite = AddComponent<Sprite>(
                new Sprite(
                    fishTexture,
                    (int) _spriteAsset.FrameSize.X,
                    (int) _spriteAsset.FrameSize.Y,
                    _flipped ? SpriteEffects.FlipHorizontally : SpriteEffects.None
                )
            );

            _sprite.AddAnimation(_spriteAsset.Animations["Swim"], "Swim");

            _sprite.Play("Swim");
        }
    }
}
