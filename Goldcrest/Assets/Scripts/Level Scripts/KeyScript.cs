using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World); // Rotates the key to look interesting
    }

    // Picks up and destroys key on collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.Instance.hasKey = true;// Set the has key state active

            FindObjectOfType<AudioManager>().Play("KeyPickup");

            Destroy(gameObject); // Destroys key
        }
    }
}
