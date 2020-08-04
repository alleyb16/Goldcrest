using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/Demo", LoadSceneMode.Single);
    }
    public void startLevel2()
    {
        SceneManager.LoadScene("Scenes/Level1", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        print("Quit");
        Application.Quit();
    }
}
