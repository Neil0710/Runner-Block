using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject tapToStart;
    public GameObject scoreText;

    private void Start()
    {
        gameOverPanel.SetActive(false);
        tapToStart.SetActive(true);
        scoreText.SetActive(false);
        PauseGame();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)|| Input.GetKeyDown(KeyCode.KeypadEnter)|| Input.GetKey(KeyCode.Space))
        {
           StartGame();
           
        }
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        scoreText.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene("RunnerBlock");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        tapToStart.SetActive(false);
        Time.timeScale = 1f;
        scoreText.SetActive(true);
    }
}
