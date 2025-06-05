using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.7f;
    void Update()
    {
        transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
    }
}
