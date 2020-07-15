using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using RetrogradeJam.Entities.Battle;
using RetrogradeJam.Data;

namespace RetrogradeJam.Screens
{
    public class BattleScreen : Screen
    {
        private BattleFish _enemyFish;
        private BattleFishData _enemyData;
        private Vector2 _enemyPosition = new Vector2(156, 15);   // Anchored by top-right;
        private BattleFish _playerFish;
        private BattleFishData _playerData;
        private Vector2 _playerPosition = new Vector2(4, 93);    // Anchored by bottom-left.

        public BattleScreen(ContentManager content, ScreenManager screenManager) : base(content, screenManager) { }

        public override void Initialize()
        {
            // Get out of here if we don't have the necessary data to battle. :)
            if (GameState.Instance.CurrentBattle == null || GameState.Instance.CurrentBattleFish == null) {
                _screenManager.LoadScreen("Start");

                return;
            }

            _playerData = GameState.Instance.CurrentBattleFish;
            _enemyData = GameState.Instance.CurrentBattle.Opponent;
            // Background.
            // @TODO

            // Opponents entities.
            _playerFish = new BattleFish(_entityManager, "player-fish", _playerData.FishType);
            _enemyFish = new BattleFish(_entityManager, "enemy-fish", _enemyData.FishType, true);

            _entityManager.AddEntity(_playerFish);
            _entityManager.AddEntity(_enemyFish);

            // UI.
            // @TODO
        }
    }
}
