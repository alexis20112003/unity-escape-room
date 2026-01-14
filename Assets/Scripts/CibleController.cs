using UnityEngine;

public class CibleController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.GetComponent<Collider>().CompareTag("Projectile"))
        {
            print("Touché !");
        }
    }
}
