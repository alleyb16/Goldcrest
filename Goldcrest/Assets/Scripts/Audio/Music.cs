using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    AudioSource fluteSalad;

    // Start is called before the first frame update
    void Start()
    {
        fluteSalad = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startJammin()
    {
        fluteSalad.Play(0);
    }
}
