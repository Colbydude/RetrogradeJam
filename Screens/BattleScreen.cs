using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using RetrogradeJam.Entities.Battle;
using RetrogradeJam.Data;

namespace RetrogradeJam.Screens
{
    public class BattleScreen : Screen
    {
        private BattleFish _enemyFish;
        private Vector2 _enemyPosition = new Vector2(156, 15);   // Anchored by top-right;
        private BattleFish _playerFish;
        private Vector2 _playerPosition = new Vector2(4, 93);    // Anchored by bottom-left.

        public BattleScreen(ContentManager content, ScreenManager screenManager) : base(content, screenManager) { }

        public override void Initialize()
        {
            // Background.
            // @TODO

            // Opponents.
            _playerFish = new BattleFish(_entityManager, "player-fish", FishType.BlueberryClownFish);
            _enemyFish = new BattleFish(_entityManager, "enemy-fish", FishType.AshBombFish);

            _entityManager.AddEntity(_playerFish);
            _entityManager.AddEntity(_enemyFish);

            // UI.
            // @TODO
        }

        /// <summary>
        /// Public method to initialize a battle and setup its parameters.
        /// </summary>
        public void InitBattle()
        {
            // @TODO
            // Setup battle parameters.

            LoadContent();
        }
    }
}
