using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private float _timeToOpen = 3.0f;
    [SerializeField] private float _speed = 8.0f;

    private float _timeRemaining;

    private void Awake()
    {
        Open();
    }

    private void Update()
    {
        if (_timeRemaining <= 0f)
        {
            // Nothing to do
            return;
        }

        transform.position += Time.deltaTime * _speed * transform.up;
        _timeRemaining -= Time.deltaTime;
    }

    private void Open()
    {
        _timeRemaining = _timeToOpen;
    }
}
