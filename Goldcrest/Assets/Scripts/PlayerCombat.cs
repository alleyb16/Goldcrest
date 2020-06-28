using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform attackPoint;
    //public float attackRange = 0.5f;
    private float attackRange;
    public LayerMask enemyLayers;

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
        print(hitEnemies);

        // Damage enemies
        foreach (Collider enemy in hitEnemies)
        {
            //apply damage
            print("hit " + enemy.name);
            enemy.GetComponent<BasicEnemy>().TakeDamage(GameManager.Instance.weaponDamage);

            // ADD KNOCKBACK
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
