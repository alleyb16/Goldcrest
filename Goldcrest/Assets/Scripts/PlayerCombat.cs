using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform attackPoint;
    //public float attackRange = 0.5f;
    private float attackRange;
    public LayerMask enemyLayers;

    Vector3 hitDirection = new Vector3();

    void Start()
    {
        attackRange = GameManager.Instance.weaponRange;
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void Attack() // ATTACKING CODE HERE
    {
        print("attack!");
        // Play attack animation

        // Detect enemies in range
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        //print(hitEnemies);

        // Damage enemies
        foreach (Collider enemy in hitEnemies)
        {
            //apply damage
            print("hit " + enemy.name);
            enemy.GetComponent<BasicEnemy>().TakeDamage(GameManager.Instance.weaponDamage);

            // ADD KNOCKBACK
            hitDirection = enemy.transform.position - GameObject.FindWithTag("Player").transform.position; // Calculates angle between player and enemy
            enemy.GetComponent<Rigidbody>().AddForce(hitDirection.normalized * GameManager.Instance.weaponKnockback, ForceMode.Impulse); // Knocks enemy away is specified direction
        }
    }

    // Displays targeted area of effect
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
