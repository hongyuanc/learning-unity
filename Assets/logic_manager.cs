using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic_manager : MonoBehaviour
{
    public int score = 0;
    public Text playerScore;
    public GameObject gameOverScene;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        score += scoreToAdd;
        playerScore.text = score.ToString();
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void returnMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void gameOver()
    {
        gameOverScene.SetActive(true);

    }
}
