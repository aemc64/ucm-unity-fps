using UnityEngine;

public class RespawnOnTrigger : MonoBehaviour
{
    [SerializeField] private Transform _respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = _respawnPoint.position;
            other.transform.rotation = _respawnPoint.rotation; // Match rotation of the respawn point
            
            Physics.SyncTransforms();
        }
    }
}
