using UnityEngine;
using UnityEngine.Events;

public class TriggerAreaController : MonoBehaviour
{
    public UnityEvent OnEnter;
    public UnityEvent OnCloser;
    private void OnTriggerEnter(Collider other) {
        print(other.name);
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            OnEnter?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            OnCloser?.Invoke();
        }
    }

}
