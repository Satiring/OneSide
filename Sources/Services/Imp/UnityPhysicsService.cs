using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class UnityPhysicsService: Service, IPhysicsService
{
    public UnityPhysicsService(Contexts contexts) : base(contexts)
    {
    }
 
    public int Square2DCast(Vector2 position, float side, RaycastHit2D[] buffer, int layerMask)
    {
        Vector2 direction = new Vector2(0,-1);
        // 
        return Physics2D.BoxCastNonAlloc(position, new Vector2(side,side), 0f, direction, buffer, Mathf.Infinity, layerMask);
    }
}