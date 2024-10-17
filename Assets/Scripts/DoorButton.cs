using UnityEngine;

public class DoorButton : MonoBehaviour
{
    [SerializeField] private Door _door;
    [SerializeField] private Collider _trigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _door.Open();
            _trigger.enabled = false; // Disables the trigger to prevent calling Door.Open multiple times
        }
    }
}
