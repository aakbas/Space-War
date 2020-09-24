using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadGameOver()
    {
        StartCoroutine(DelayedGameOver());
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
        
    } 

    public void LoadStartMenu()
    {
        FindObjectOfType<GameSession>().ResetGame();
        SceneManager.LoadScene("Start Menu");
       
    }

    IEnumerator DelayedGameOver()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Game Over");
    }

}
