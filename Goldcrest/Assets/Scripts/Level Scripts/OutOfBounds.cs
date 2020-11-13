using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public Level1Script level1Script;
    public Level2Script level2Script;
    public Level3Script level3Script;
    //public Level4Script level4Script;
    public DemoLevelScript demo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) //When player collides with the level trigger box...
    {
        if (other.tag == "Player")
        {
            if (GameManager.Instance.inLevel1)
            {
                level1Script.gameOver = true;
                level1Script.UI.SetActive(false);
                level1Script.levelFail.SetActive(true); // Set level over and display fail menu
            }
            if (GameManager.Instance.inLevel2)
            {
                level2Script.gameOver = true;
                level2Script.UI.SetActive(false);
                level2Script.levelFail.SetActive(true);
            }
            if (GameManager.Instance.inLevel3)
            {
                level3Script.gameOver = true;
                level3Script.UI.SetActive(false);
                level3Script.levelFail.SetActive(true);
            }
            if (GameManager.Instance.inDemo)
            {
                demo.gameOver = true;
                demo.UI.SetActive(false);
                demo.levelFail.SetActive(true);
            }

            Time.timeScale = 0f; //Slows speed to a pause
        }

    }
}
