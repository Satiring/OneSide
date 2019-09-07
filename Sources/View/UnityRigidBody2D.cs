using UnityEngine;

public class UnityRigidBody2D : MonoBehaviour, IRigidBody2D
{
    // controlling a kinematic body.
    
    
    
    [SerializeField] private Rigidbody2D _rb2d;

    public Vector2 Velocity
    {
        get { return _rb2d.velocity; }
        set { _rb2d.velocity = value; }
    }

    public bool isKinematic
    {
        get { return _rb2d.isKinematic; }
        set { _rb2d.isKinematic = value; }
    }
    
}