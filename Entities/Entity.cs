using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using RetrogradeJam.Entities.Components;
using System;
using System.Collections.Generic;

namespace RetrogradeJam.Entities
{
    public class Entity
    {
        public bool IsActive;

        protected List<Component> _components = new List<Component>();
        protected Dictionary<Type, Component> _componentTypeMap = new Dictionary<Type, Component>();
        protected EntityManager _manager;

        public string Id { get; private set; }

        public Entity(EntityManager manager, string entityName)
        {
            _manager = manager;
            Id = entityName;
        }

        public T AddComponent<T>(T component) where T : Component
        {
            component.Entity = this;

            _components.Add(component);
            _componentTypeMap.Add(typeof(T), component);

            component.Initialize();

            return component;
        }

        public T GetComponent<T>() where T : Component
        {
            return (T)_componentTypeMap[typeof(T)];
        }

        public bool HasComponent<T>()
        {
            return _componentTypeMap.ContainsKey(typeof(T));
        }

        public virtual void Destroy()
        {
            IsActive = false;
        }

        public virtual void Initialize()
        {
            IsActive = true;
        }

        public virtual void LoadContent(ContentManager content)
        {
            //
        }

        public virtual void UnloadContent(ContentManager content)
        {
            //
        }

        public virtual void Update(GameTime gameTime)
        {
            _components.ForEach(component => {
                component.Update(gameTime);
            });
        }

        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            _components.ForEach(component => {
                component.Draw(spriteBatch, gameTime);
            });
        }
    }
}
