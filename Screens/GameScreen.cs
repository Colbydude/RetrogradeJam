using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using RetrogradeJam.Entities;
using System;

namespace RetrogradeJam.Screens
{
    public class GameScreen : Screen
    {
        public GameScreen(ContentManager content, ScreenManager screenManager) : base(content, screenManager) {}

        public override void LoadContent()
        {
            Player player = new Player(_entityManager, "player");
            _entityManager.AddEntity(player);

            base.LoadContent();
        }
    }
}
