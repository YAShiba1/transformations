using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        IncreaseSize();
    }

    private void IncreaseSize()
    {
        transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;
    }
}
