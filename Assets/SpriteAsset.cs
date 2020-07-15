using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace RetrogradeJam.Assets
{
    public class SpriteAsset
    {
        public Dictionary<string, Animation> Animations { get; private set; }
        public string FileName { get; private set; }
        public Vector2 FrameSize { get; private set; }

        public SpriteAsset(string fileName, Vector2 frameSize, Dictionary<string, Animation> animations = null)
        {
            FileName = fileName;
            FrameSize = frameSize;
            Animations = animations;
        }
    }
}
