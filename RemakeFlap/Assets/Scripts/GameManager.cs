using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] GameObject _gameOverCanvas;
    [SerializeField] GameObject _startGame;
    [SerializeField] Rigidbody2D _rigidbodyPlayer;
    [SerializeField] GameObject _pipeSpawner;


    bool isPlaying = false;

    private void Awake()
    {
        if(instance == null)
            instance = this;
        Time.timeScale = 1.0f;
        _pipeSpawner.SetActive(false);
    }

    private void Start()
    {
        _startGame.SetActive(true);
        _rigidbodyPlayer.gravityScale = 0f;


    }
    private void Update()
    {
        if(!isPlaying && (Mouse.current.leftButton.wasPressedThisFrame || Input.GetKeyDown(KeyCode.Space)))
        {
            _startGame.SetActive(false);
            isPlaying = !isPlaying;
            _rigidbodyPlayer.gravityScale = 1.0f;
            _pipeSpawner.SetActive(true);
        }
    }
    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
