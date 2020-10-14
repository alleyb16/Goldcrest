using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public Level1Script levelScript;

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
            levelScript.gameOver = true;
            levelScript.levelFail.SetActive(true); // Set level over and display fail menu

            Time.timeScale = 0f; //Slows speed to a pause
        }

    }
}
