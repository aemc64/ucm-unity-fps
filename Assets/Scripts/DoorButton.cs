using UnityEngine;

public class DoorButton : MonoBehaviour
{
    [SerializeField] private Door _door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _door.Open();
        }
    }
}
