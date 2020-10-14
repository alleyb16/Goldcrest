using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{

    public bool gamePaused = false;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseGame()
    {
        if (!gamePaused)
        {
            Time.timeScale = 0f; //Slows speed to a pause
            gamePaused = true;
            
        }
    }

    public void resumeGame()
    {
        Time.timeScale = 1f; // Sets speed back to normal
        gamePaused = false;
    }

    public void loadMenu()
    {
        Time.timeScale = 1f;
        gamePaused = false;
        SceneManager.LoadScene("Scenes/Menu", LoadSceneMode.Single);
    }
}
