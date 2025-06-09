using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _hightScoreText;
    [SerializeField] private TextMeshProUGUI _overScore;
    [SerializeField] AudioManager _audioManager;

    public bool isHighScore = false;
    private int _score;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        _currentScoreText.text = _score.ToString();

        _hightScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }
    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _hightScoreText.text = _score.ToString();
            isHighScore = true;
        }
    }
    public void UpdateScore()
    {
        _score++;
        _audioManager.PlayPointSound();
        _currentScoreText.text = _score.ToString();
        _overScore.text = _score.ToString();
        UpdateHighScore();
    }
}
