using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _flyPow = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;
    [SerializeField] AudioManager _audioManager;

    
    private Rigidbody2D _rb;
    bool isPlaying = true;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame || Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = Vector2.up * _flyPow;
            if(isPlaying) _audioManager.PlayJumpSound();
        }
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        _audioManager.PlayDieSound();
        isPlaying = false;
        GameManager.instance.GameOver();
    }
}
