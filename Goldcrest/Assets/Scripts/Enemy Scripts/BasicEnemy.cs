using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicEnemy : MonoBehaviour
{
    private Animator anim;
    public float maxHealth = 75f;
    private float currentHealth;

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

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Die animation
        anim.SetBool("die", true);
        // Disable Enemy
        GameManager.Instance.currentScore += 15;
        GetComponent<CapsuleCollider>().enabled = false;
        //this.enabled = false;
        Destroy(gameObject, 1);
    }
}
