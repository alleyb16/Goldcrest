using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(onDeath), 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void onDeath()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.playerHealth -= 20;
            Destroy(gameObject);
            // KNOCKBACK ON PLAYER (DOESN'T WORK RN)
            //hitDirection = player.transform.position - transform.position; // Calculates angle between player and enemy
            //player.GetComponent<Rigidbody>().AddForce(hitDirection.normalized * 50, ForceMode.Impulse); // Knocks enemy away is specified direction
        }
    }
}
