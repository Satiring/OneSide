using UnityEngine;

public interface ICollisionEmissionService
{
    void EmitCollision(RaycastHit2D hit2D);
}