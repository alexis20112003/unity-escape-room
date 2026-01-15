using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform _playerCamera;

    private void Start() {
        _playerCamera = Camera.main.transform;
    }

    private void Update() {
        Vector3 directionToPlayer = _playerCamera.position - transform.position;
        directionToPlayer.y = 0;

        transform.rotation = Quaternion.LookRotation(directionToPlayer);
    }
}
