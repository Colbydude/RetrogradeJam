using Microsoft.Xna.Framework;
using RetrogradeJam.Assets;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RetrogradeJam.Data
{
    public sealed class FishData
    {
        /// <summary>
        /// All the reusable animations to have for each fish.
        /// </summary>
        public static ReadOnlyDictionary<string, Animation> FishAnimations { get; } = new ReadOnlyDictionary<string, Animation>(
            new Dictionary<string, Animation> {
                { "Swim", new Animation(0, 2, 180) }
            }
        );

        /// <summary>
        /// All the sprites, frame sizes, an animations for the fish.
        /// </summary>
        public static ReadOnlyDictionary<FishType, SpriteAsset> FishSpriteAssets { get; } = new ReadOnlyDictionary<FishType, SpriteAsset>(
            new Dictionary<FishType, SpriteAsset> {
                { FishType.AshBombFish, new SpriteAsset { FileName = "Sprites/bomb-fish-ash", FrameSize = new Vector2(64, 64), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },
                { FishType.NuclearBombFish, new SpriteAsset { FileName = "Sprites/bomb-fish-nuclear", FrameSize = new Vector2(64, 64), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },
                { FishType.ToxicBombFish, new SpriteAsset { FileName = "Sprites/bomb-fish-toxic", FrameSize = new Vector2(64, 64), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },

                { FishType.CorrectCatfish, new SpriteAsset { FileName = "Sprites/catfish-correct", FrameSize = new Vector2(48, 48), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },
                { FishType.TastyCatfish, new SpriteAsset { FileName = "Sprites/catfish-tasty", FrameSize = new Vector2(48, 48), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },
                { FishType.TimelessCatfish, new SpriteAsset { FileName = "Sprites/catfish-timeless", FrameSize = new Vector2(48, 48), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },

                { FishType.BlueberryClownFish, new SpriteAsset { FileName = "Sprites/clown-fish-blueberry", FrameSize = new Vector2(32, 32), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },
                { FishType.BubblegumClownFish, new SpriteAsset { FileName = "Sprites/clown-fish-bubblegum", FrameSize = new Vector2(32, 32), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },
                { FishType.CreamsicleClownFish, new SpriteAsset { FileName = "Sprites/clown-fish-creamsicle", FrameSize = new Vector2(32, 32), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },

                { FishType.LuckStarSquid, new SpriteAsset { FileName = "Sprites/star-squid-luck", FrameSize = new Vector2(40, 40), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },
                { FishType.RadiantStarSquid, new SpriteAsset { FileName = "Sprites/star-squid-radiant", FrameSize = new Vector2(40, 40), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },
                { FishType.StarsignStarSquid, new SpriteAsset { FileName = "Sprites/star-squid-starsign", FrameSize = new Vector2(40, 40), Animations = FishAnimations.ToDictionary(k => k.Key, v => v.Value) } },

                // Shark
            }
        );
    }
}
