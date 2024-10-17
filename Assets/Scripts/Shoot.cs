using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Rigidbody _projectilePrefab;
    [SerializeField] private Transform _projectileSpawnPoint;
    [SerializeField] private float _projectileSpeed = 2.0f;
    [SerializeField] private float _fireCooldown = 1.0f;

    private float _timer;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Mouse left button
        {
            Rigidbody projectile = Instantiate(_projectilePrefab, _projectileSpawnPoint.position, Quaternion.identity);
            projectile.velocity = _projectileSpawnPoint.forward * _projectileSpeed;

            _timer = _fireCooldown;
        }
    }
}
