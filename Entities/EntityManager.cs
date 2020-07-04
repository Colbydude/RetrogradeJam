using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
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

            entity.Initialize();

            return entity;
        }

        public T AddEntity<T>(T entity) where T : Entity
        {
            _entities.Add(entity);

            entity.Initialize();

            return entity;
        }

        public void ClearEntities()
        {
            _entities.Clear();
        }

        public Entity GetEntity(string entityName)
        {
            return _entities.Find(entity => entity.Id == entityName);
        }

        public void LoadContent(ContentManager content)
        {
            _entities.ForEach(entity => {
                entity.LoadContent(content);
            });
        }

        public void UnloadContent(ContentManager content)
        {
            _entities.ForEach(entity => {
                entity.UnloadContent(content);
            });

            ClearEntities();
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
