using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _resetX = -6f;
    [SerializeField] private float _startX = 6f;

    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;

        if (transform.position.x < _resetX)
        {
            transform.position = new Vector3(_startX, transform.position.y, transform.position.z);
        }
    }
}
