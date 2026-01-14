using UnityEngine;

public class PorteController : MonoBehaviour
{

    public bool opened;

    public Transform pivot;
    public Transform closedReference;
    public Transform openedReference;
    public float vitesseRotation;

    // Update is called once per frame
    void Update()
    {
        if (opened)
        {
            //pivot.localRotation = openedReference.localRotation;
            RotationTransform(openedReference.localRotation, vitesseRotation, pivot);
        }
        else
        {
            //pivot.localRotation = closedReference.localRotation;
            RotationTransform(closedReference.localRotation, vitesseRotation, pivot);
        }
    }

    public void Open()
    {
        opened = true;
    }

    public void RotationTransform(Quaternion rotationCible, float vitesseRotation, Transform transform)
    {
        transform.localRotation = Quaternion.Lerp(
            transform.rotation,
            rotationCible,
            vitesseRotation * Time.deltaTime
        );
    }
}
