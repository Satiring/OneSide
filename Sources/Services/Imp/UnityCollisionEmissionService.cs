using Entitas;
using UnityEngine;

public class UnityCollisionEmissionService: Service, ICollisionEmissionService
{
    public UnityCollisionEmissionService(Contexts contexts) : base(contexts)
    {
    }

    public void EmitCollision(RaycastHit2D hit2D)
    {
        // Collision Component
        var entity = _contexts.game.CreateEntity();
        entity.isCollision = true;
        
        // Set Collider ID.
        var view = hit2D.collider.gameObject.GetComponent<IView>();
        if (view != null)
        {
             
            entity.AddColliderID(view.Id);

        }
    }
}