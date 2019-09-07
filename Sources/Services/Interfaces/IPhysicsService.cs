using UnityEngine;

public interface IPhysicsService
{
    int Square2DCast(Vector2 position, float side, RaycastHit2D[] buffer, int layerMask);
}