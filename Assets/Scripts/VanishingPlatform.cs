using UnityEngine;

public class VanishingPlatform : MonoBehaviour
{
    [SerializeField] private float _timeActive = 3.0f;
    [SerializeField] private float _timeInactive = 3.0f;

    private Renderer _renderer;
    private Collider _collider;

    private float _timeRemaining;
    private bool _active = true;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _collider = GetComponent<Collider>();

        UpdateVisibilityAndResetTimer();
    }

    private void Update()
    {
        _timeRemaining -= Time.deltaTime;
        if (_timeRemaining >= 0f)
        {
            // Nothing to do
            return;
        }

        _active = !_active;
        UpdateVisibilityAndResetTimer();
    }

    private void UpdateVisibilityAndResetTimer()
    {
        _renderer.enabled = _active;
        _collider.enabled = _active;
        
        _timeRemaining = _active ? _timeInactive : _timeActive;
    }
}
