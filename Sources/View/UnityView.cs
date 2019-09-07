using UnityEngine;

public class UnityView: MonoBehaviour , IView, IDestroyedListener
{
    // Cache References
    private GameObject _gameObject;
    private Transform _transform;
    private GameEntity _entity;
    
    public bool Enabled
    {
        get { return _gameObject.activeSelf;} set{_gameObject.SetActive(value);} }
    public int Id { get; set; }
    public Vector2 Position
    {
        get { return _transform.position; }
        set { _transform.position = value; }
    }
    public Transform Transform
    {
        get { return _transform; }
    }
    public void InitializeView(Contexts contexts, GameEntity gameEntity)
    {
        _gameObject = gameObject;
        _transform = transform;
        _entity = gameEntity;
        _entity.AddDestroyedListener(this);
        Id = _entity.id.Value;
    }

    public void OnDestroyed(GameEntity entity)
    {
        Destroy(_gameObject);
    }
    
    
}