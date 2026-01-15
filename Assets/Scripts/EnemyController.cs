using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform _playerCamera;
    public Rigidbody rigidbody;
    public float vitesse;
    public float distanceToStop;

    private void Start() {
        _playerCamera = Camera.main.transform;
    }

    private void Update() {
        Vector3 directionToPlayer = _playerCamera.position - transform.position;
        directionToPlayer.y = 0;

        transform.rotation = Quaternion.LookRotation(directionToPlayer);

        Vector3 movement = directionToPlayer.normalized * vitesse;
        rigidbody.linearVelocity = movement + new Vector3(0, rigidbody.linearVelocity.y, 0);

        //float distanceToStop = Vector3.Distance(transform.position, _playerCamera.position);
        //if (distanceToStop > directionToPlayer)
        //{
            //rigidbody.linearVelocity = new Vector3(0, rigidbody.linearVelocity.y, 0);
        //} 
    }
}
