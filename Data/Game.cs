using System.Collections.Generic;

namespace RetrogradeJam.Data
{
    public sealed class GameData
    {
        /// <summary>
        /// List of battles in the adventure.
        /// </summary>
        public static Dictionary<int, BattleData> Battles = new Dictionary<int, BattleData> {
            { 1, new BattleData(null, new BattleFishData(FishType.CreamsicleClownFish, ColorType.Neutral, 2)) },
            { 2, new BattleData(null, new BattleFishData(FishType.BubblegumClownFish, ColorType.Red, 2)) },
            { 3, new BattleData(null, new BattleFishData(FishType.LuckStarSquid, ColorType.Yellow, 3)) },

            { 4, new BattleData(null, new BattleFishData(FishType.BlueberryClownFish, ColorType.Blue, 2)) },
            { 5, new BattleData(null, new BattleFishData(FishType.RadiantStarSquid, ColorType.Purple, 3)) },
            { 6, new BattleData(null, new BattleFishData(FishType.AshBombFish, ColorType.Red, 5)) },

            { 7, new BattleData(null, new BattleFishData(FishType.StarsignStarSquid, ColorType.Purple, 3)) },
            { 8, new BattleData(null, new BattleFishData(FishType.CorrectCatfish, ColorType.Orange, 4)) },
            { 9, new BattleData(null, new BattleFishData(FishType.NuclearBombFish, ColorType.Blue, 5)) },

            { 10, new BattleData(null, new BattleFishData(FishType.TastyCatfish, ColorType.Yellow, 4)) },
            { 11, new BattleData(null, new BattleFishData(FishType.TimelessCatfish, ColorType.Green, 4)) },
            { 12, new BattleData(null, new BattleFishData(FishType.ToxicBombFish, ColorType.Purple, 5)) },

            { 13, new BattleData(null, new BattleFishData(FishType.DesertShadeShark, ColorType.Neutral, 6)) },
        };
    }
}
