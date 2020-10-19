using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronDoorScript : MonoBehaviour
{
    // Destroys door when player enters range with key
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (GameManager.Instance.hasKey == true)
            {
                Destroy(gameObject, 1); // Destroys door
                GameManager.Instance.hasKey = false;

                // Play unlock sound

            }
        }
    }
}
