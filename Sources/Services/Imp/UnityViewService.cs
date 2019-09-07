using System;
using System.Collections.Generic;
using UnityEngine;

public sealed class UnityViewService : Service, IViewService{
    
        private readonly Transform _root;
        
        // Buffers
        private readonly List<IEventListener> _eventListenerBuffer;
        
        public UnityViewService(Contexts contexts) : base(contexts)
        {
            _root = new GameObject("ViewRoot").transform;
            _eventListenerBuffer = new List<IEventListener>(16);
        }    


        
        // Magic here.

        public void LoadAsset(Contexts contexts, GameEntity gameEntity, string asset)
        {
            var viewObject = GameObject.Instantiate(Resources.Load<GameObject>(string.Format("Prefabs/{0}", asset)), _root);
            if (viewObject == null)
                throw new NullReferenceException(string.Format("Prefabs/{0} not found!", asset));

            var rigidbody2D = viewObject.GetComponent<IRigidBody2D>();
            if (rigidbody2D != null)
                gameEntity.AddRigidBody2D(newValue: rigidbody2D);
            if (gameEntity.hasRigidBody2D)
            {
                Debug.Log("Tengo RBD2");
            }

            
            var view = viewObject.GetComponent<IView>();
            if (view != null)
            {
                view.InitializeView(contexts, gameEntity);
                Debug.Log("Añadido la Vista");
                gameEntity.AddView(view);
            }

            viewObject.GetComponents(_eventListenerBuffer);
            foreach (var listener in _eventListenerBuffer)
            {
                
                listener.RegisterListener(gameEntity);
            }
                
                
            
        }
    
}