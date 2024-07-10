using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_script : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Intermission;
    public float duration = 2f;

    public void startGame()
    {
        StartCoroutine(StartGameSequence());
    }

    private IEnumerator StartGameSequence()
    {
        Menu.SetActive(false);
        Intermission.SetActive(true);

        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene("Game");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}