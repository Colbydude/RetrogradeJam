using RetrogradeJam.Data;
using System;

namespace RetrogradeJam
{
    public sealed class GameState
    {
        /// <summary>
        /// Lazy-initialied instance of the game state.
        /// </summary>
        private static readonly Lazy<GameState> lazy = new Lazy<GameState>(() => new GameState());

        /// <summary>
        /// The actual game state instance.
        /// </summary>
        public static GameState Instance { get { return lazy.Value; } }

        /// <summary>
        /// The current battle data to load information from for the battle scene.
        /// </summary>
        /// <value></value>
        public BattleData CurrentBattle { get; set; }

        /// <summary>
        /// Your currently selected fish to use for battle.
        /// </summary>
        /// <value></value>
        public BattleFishData CurrentBattleFish { get; set; }

        private GameState() { }
    }
}
