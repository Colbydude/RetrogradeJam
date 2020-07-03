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
        private GraphicsDeviceManager _graphics;

        public EntityManager(GraphicsDeviceManager graphicsManager)
        {
            _graphics = graphicsManager;
        }

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

        public Entity GetEntity(string entityName)
        {
            return _entities.Find(entity => entity.Id == entityName);
        }

        public GraphicsDeviceManager GetGraphicsDeviceManager()
        {
            return _graphics;
        }

        public void LoadContent(ContentManager content)
        {
            _entities.ForEach(entity => {
                entity.LoadContent(content);
            });
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
