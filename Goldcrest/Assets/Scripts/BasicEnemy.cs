using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicEnemy : MonoBehaviour
{
    private Animator anim;
    public float maxHealth = 100f;
    private float currentHealth;

    public Image enemyHealthbar;
    private float healthPercent;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = maxHealth;
        //enemyHealthbar = GameObject.Find("enemyHealth").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
       // updateHealth();
       // print(enemyHealthbar.fillAmount);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        enemyHealthbar.fillAmount = currentHealth / maxHealth;

        // play animation

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void updateHealth()
    {
        //healthPercent = currentHealth / maxHealth;
       // enemyHealthbar.fillAmount = healthPercent;
    }

    void Die()
    {
        // Die animation
        anim.SetBool("die", true);
        //anim.Play("Die");
        // Disable Enemy

        print("Enemy Defeated");
        GameManager.Instance.currentScore += 15;
        GetComponent<CapsuleCollider>().enabled = false;
        //this.enabled = false;
        Destroy(gameObject, 1);
    }
}
