using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    private float maxDoorHealth = 50f;
    private float currentDoorHealth;

    

    // Start is called before the first frame update
    void Start()
    {
        currentDoorHealth = maxDoorHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentDoorHealth -= damage;
        //enemyHealthbar.fillAmount = currentHealth / maxHealth;

        // play animation

        if (currentDoorHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Die animation

        // Disable Enemy

        print("Enemy Defeated");
        //GameManager.Instance.currentScore += 15;
        GetComponent<BoxCollider>().enabled = false;
        //this.enabled = false;
        Destroy(gameObject, 1);
    }
}
