using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float initialForce;

    private void Start() {
        rigidbody.AddForce(transform.forward * initialForce, ForceMode.Impulse);
    }
}
