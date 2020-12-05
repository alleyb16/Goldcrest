using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicEnemy : MonoBehaviour
{
    private Animator anim;
    public float maxHealth = 75f;
    public float currentHealth;

    public Image enemyHealthbar;
    private float healthPercent;

    public bool isDead = false;

    public ParticleSystem blood;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        enemyHealthbar.fillAmount = currentHealth / maxHealth;

        blood.Play();

        // play sound effects
        if (gameObject.tag == "Enemy")
        {
            FindObjectOfType<AudioManager>().Play("ShadeHit");
        }
        if (gameObject.tag == "Ranger")
        {
            if (currentHealth > 0)
                FindObjectOfType<AudioManager>().Play("ArcherHit");
        }
        if (gameObject.tag == "Mini Boss")
        {
            if (currentHealth > 0)
            FindObjectOfType<AudioManager>().Play("BruteHit");
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        
        // Die animation
        anim.SetBool("die", true);
        anim.SetBool("atk", false);
        anim.SetBool("run", false);
        
        isDead = true;
        //anim.Play("die");
        // Disable Enemy

        if (gameObject.tag == "Enemy")
        {
            GameManager.Instance.currentScore += 15;
            // Play death sound
        }
        if (gameObject.tag == "Ranger")
        {
            GameManager.Instance.currentScore += 15;
            FindObjectOfType<AudioManager>().Play("ArcherDeath");
        }
        if (gameObject.tag == "Mini Boss")
        {
            GameManager.Instance.currentScore += 40;
            GameManager.Instance.bossDead = true;

            FindObjectOfType<AudioManager>().Play("BruteDeath");
        }
        if (gameObject.tag == "Rat")
        {
            GameManager.Instance.currentScore += 1;
            FindObjectOfType<AudioManager>().Play("RatDeath");
        }
        print("Ima die");
        GetComponent<CapsuleCollider>().enabled = false;
        //this.enabled = false;
        Destroy(gameObject, 1);
    }
}
