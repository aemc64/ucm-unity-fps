using UnityEngine;

public class ProjectileDestroy : MonoBehaviour
{
    [SerializeField] private float _lifeTime = 5.0f;
    [SerializeField] private bool _destroyOnCollision;

    private void Start()
    {
        Destroy(gameObject, _lifeTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!_destroyOnCollision)
        {
            return;
        }
        
        Destroy(gameObject);
    }
}
