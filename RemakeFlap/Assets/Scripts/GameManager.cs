using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] GameObject _gameOverCanvas;

    private void Awake()
    {
        if(instance == null)
            instance = this;
        Time.timeScale = 1.0f;
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
