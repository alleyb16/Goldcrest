using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World); // Rotates the coin to look interesting
    }


    // Picks up and destroys coin on collision
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameManager.Instance.coinsCollected += 1;//Add value
            GameManager.Instance.currentScore += 10;// Adds score

            Destroy(gameObject); // Destroys coin
        }
    }
}
