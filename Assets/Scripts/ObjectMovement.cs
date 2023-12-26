using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        Move();
        Rotation();
        IncreaseSize();
    }

    private void Move()
    {
        transform.Translate(0, 0, -_moveSpeed * Time.deltaTime);
    }

    private void Rotation()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

    private void IncreaseSize()
    {
        transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;
    }
}
