using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logic_manager : MonoBehaviour
{
    public int score = 0;
    public Text playerScore;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        score += scoreToAdd;
        playerScore.text = score.ToString();
    }
}
