using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(0, 0, -_moveSpeed * Time.deltaTime);
    }
}
