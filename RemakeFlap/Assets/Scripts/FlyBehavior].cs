using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _flyPow = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;

    
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            _rb.velocity = Vector2.up * _flyPow;
        }
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }
}
