using UnityEngine;

public class Shoot : MonoBehaviour
{
    [Header("Common")]
    [SerializeField] private Rigidbody _projectilePrefab;
    [SerializeField] private Transform _shootOrigin;
    [SerializeField] private float _fireCooldown = 1.0f;
    [SerializeField] private AudioSource _audioSource;

    [Header("Projectile")]
    [SerializeField] private float _projectileSpeed = 2.0f;

    [Header("Instant Shoot")]
    [SerializeField] private ParticleSystem _instantShootParticles;
    [SerializeField] private float _instantShootForce;
    [SerializeField] private float _instantShootRange = 100f;
    
    private float _timer;

    private void Update()
    {
        if (Input.GetMouseButton(0) && _timer <= 0f) // Mouse left button
        {
            if (_projectilePrefab != null)
            {
                ShootProjectile();
            }
            else
            {
                ShootInstant();
            }

            _timer = _fireCooldown;
            _audioSource.Play();
            return;
        }

        _timer = Mathf.Max(_timer - Time.deltaTime, 0f);
    }

    private void ShootProjectile()
    {
        Rigidbody projectile = Instantiate(_projectilePrefab, _shootOrigin.position, Quaternion.identity);
        projectile.velocity = _shootOrigin.forward * _projectileSpeed;
    }

    private void ShootInstant()
    {
        Physics.Raycast(_shootOrigin.position, _shootOrigin.forward, _instantShootRange);
    }
}
