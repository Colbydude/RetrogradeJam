using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace RetrogradeJam.Entities
{
    public class EntityManager
    {
        private List<Entity> _entities = new List<Entity>();

        public Entity AddEntity(string entityName)
        {
            Entity entity = new Entity(this, entityName);
            _entities.Add(entity);

            return entity;
        }

        public Entity GetEntity(string entityName)
        {
            return _entities.Find(entity => entity.Id == entityName);
        }

        public void Update(GameTime gameTime)
        {
            _entities.ForEach(entity => {
                entity.Update(gameTime);
            });

            _entities.RemoveAll(e => !e.IsActive);
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            _entities.ForEach(entity => {
                entity.Draw(spriteBatch, gameTime);
            });
        }
    }
}
