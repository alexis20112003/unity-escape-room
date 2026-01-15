using UnityEngine;

public class CibleController : MonoBehaviour
{
    public int vie;
    public float intansiteTremblement;
    public float frequenceTremblement;
    public float dureeTremblement;
    private Vector3 _basePosition;

    private void Start()
    {
        _basePosition = transform.position;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Projectile"))
        {
            print("Touché !");
            Damage();
        }
    }

    private void Damage()
    {
        vie--;
        moove();
        if(vie == 0)
        {
            Destroy(gameObject);
        }
    }

    private void moove()
    {
        float time = Time.time * frequenceTremblement;

        Vector3 randomPosition = new Vector3(
            (Mathf.PerlinNoise(time, time + 10) - 0.5f) * intansiteTremblement,
            (Mathf.PerlinNoise(time + 100, time + 200) - 0.5f) * intansiteTremblement,
            (Mathf.PerlinNoise(time + 1000, time + 2000) - 0.5f) * intansiteTremblement
        );
    }
}
