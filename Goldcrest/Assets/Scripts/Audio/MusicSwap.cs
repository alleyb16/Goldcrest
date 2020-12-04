using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwap : MonoBehaviour
{

    public GameObject levelMusic;
    public GameObject bossMusic;

    private bool doOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !doOnce)
        {
            levelMusic.SetActive(false);
            bossMusic.SetActive(true);

            doOnce = true;
        }
    }
}
