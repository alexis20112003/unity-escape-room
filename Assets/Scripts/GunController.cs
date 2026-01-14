using UnityEngine;
using UnityEngine.InputSystem;

public class GunController : MonoBehaviour
{
    public InputActionReference touche;
    public GameObject projectile;

    private void OnEnable()
    {
        touche.action.Enable();
        touche.action.performed += OnTouchePressed;
    }

        private void OnDisable()
    {
        touche.action.Disable();
        touche.action.performed -= OnTouchePressed;
    }

    private void OnTouchePressed(InputAction.CallbackContext obj)
    {
        print("GOOD");
        Instantiate(projectile, transform.position, transform.rotation);
    }
}
