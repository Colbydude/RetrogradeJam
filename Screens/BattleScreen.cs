using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using RetrogradeJam.Entities;
using RetrogradeJam.Models;
using System;

namespace RetrogradeJam.Screens
{
    public class BattleScreen : Screen
    {
        private Vector2 playerPosition = new Vector2(4, 93);    // Anchored by bottom-left.
        private Vector2 enemyPosition = new Vector2(156, 15);   // Anchored by top-right;

        public BattleScreen(ContentManager content, ScreenManager screenManager) : base(content, screenManager) { }

        public override void LoadContent()
        {
            // Opponents.
            BattleFish playerFish = new BattleFish(_entityManager, "player-fish", new Fish {
                FrameSize = new Vector2(32, 32),
                SpriteAsset = "clown-fish-creamsicle"
            });

            BattleFish enemyFish = new BattleFish(_entityManager, "enemy-fish", new Fish {
                FrameSize = new Vector2(64, 64),
                SpriteAsset = "bomb-fish-ash"
            });

            _entityManager.AddEntity(playerFish);
            _entityManager.AddEntity(enemyFish);

            // UI.
            // @TODO

            base.LoadContent();
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
