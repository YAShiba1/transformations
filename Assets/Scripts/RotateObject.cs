using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }
}
