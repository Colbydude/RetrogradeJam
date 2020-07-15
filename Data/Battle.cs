using RetrogradeJam.Assets;

namespace RetrogradeJam.Data
{
    public class BattleData
    {
        public SpriteAsset Background { get; private set; }
        public BattleFishData Opponent { get; private set; }
        // Reward?

        public BattleData(SpriteAsset background, BattleFishData opponent)
        {
            Background = background;
            Opponent = opponent;
        }
    }

    public class BattleFishData
    {
        public ColorType ColorType { get; private set; }
        public FishType FishType { get; private set; }
        public int HP { get; private set; }

        public BattleFishData(FishType fishType, ColorType colorType, int hp)
        {
            FishType = fishType;
            ColorType = colorType;
            HP = hp;
        }
    }
}
