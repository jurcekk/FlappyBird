using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public Text highScore;
    public GameObject gameOver;
    public AudioSource soundEffect;
    public AudioSource gameOverSound;

    [ContextMenu("Increase")]
    public void addScore(int toAdd)
    {
        playerScore += toAdd;
        score.text = playerScore.ToString();
        soundEffect.Play();
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Fail()
    {
        gameOver.SetActive(true);
        gameOverSound.Play();
        PlayerPrefs.SetInt("Highscore", playerScore);
    }

    public void Start()
    {
        highScore.text = PlayerPrefs.GetInt("Highscore").ToString();
    }
}
