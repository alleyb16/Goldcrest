using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatNest : MonoBehaviour
{

    public GameObject rats;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // trigger enter
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            rats.SetActive(true);
        }

    }
    // set rat swarm gameobjects true
}
