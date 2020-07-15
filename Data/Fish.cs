using Microsoft.Xna.Framework;
using RetrogradeJam.Assets;
using System.Collections.Generic;

namespace RetrogradeJam.Data
{
    public sealed class FishData
    {
        /// <summary>
        /// All the reusable animations to have for each fish.
        /// </summary>
        public static Dictionary<string, Animation> FishAnimations { get; } = new Dictionary<string, Animation> {
            { "Swim", new Animation(0, 2, 180) },
        };

        /// <summary>
        /// All the sprites, frame sizes, an animations for the fish.
        /// </summary>
        public static Dictionary<FishType, SpriteAsset> FishSpriteAssets { get; } = new Dictionary<FishType, SpriteAsset> {
            { FishType.AshBombFish, new SpriteAsset("Sprites/bomb-fish-ash", new Vector2(64, 64), FishAnimations) },
            { FishType.NuclearBombFish, new SpriteAsset("Sprites/bomb-fish-nuclear", new Vector2(64, 64), FishAnimations) },
            { FishType.ToxicBombFish, new SpriteAsset("Sprites/bomb-fish-toxic", new Vector2(64, 64), FishAnimations) },

            { FishType.CorrectCatfish, new SpriteAsset("Sprites/catfish-correct", new Vector2(48, 48), FishAnimations) },
            { FishType.TastyCatfish, new SpriteAsset("Sprites/catfish-tasty", new Vector2(48, 48), FishAnimations) },
            { FishType.TimelessCatfish, new SpriteAsset("Sprites/catfish-timeless", new Vector2(48, 48), FishAnimations) },

            { FishType.BlueberryClownFish, new SpriteAsset("Sprites/clown-fish-blueberry", new Vector2(32, 32), FishAnimations) },
            { FishType.BubblegumClownFish, new SpriteAsset("Sprites/clown-fish-bubblegum", new Vector2(32, 32), FishAnimations) },
            { FishType.CreamsicleClownFish, new SpriteAsset("Sprites/clown-fish-creamsicle", new Vector2(32, 32), FishAnimations) },

            // { FishType.DesertShadeShark, new SpriteAsset("Sprites/desert-shade-shark", new Vector2(0, 0), FishAnimations) },

            { FishType.LuckStarSquid, new SpriteAsset("Sprites/star-squid-luck", new Vector2(40, 40), FishAnimations) },
            { FishType.RadiantStarSquid, new SpriteAsset("Sprites/star-squid-radiant", new Vector2(40, 40), FishAnimations) },
            { FishType.StarsignStarSquid, new SpriteAsset("Sprites/star-squid-starsign", new Vector2(40, 40), FishAnimations) },
        };
    }
}
