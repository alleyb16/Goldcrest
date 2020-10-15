using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour
{
    public Transform attackPoint;
    private float attackRange;
    public LayerMask enemyLayers;

    public bool attackReady = true;
    private float cooldownTimer;
    private float cooldownPercent;
    private float attackCooldown;

    public bool invuln = false;
    private float invulnTimer;
    private float invulnTime = .75f;

    public Image cooldown;

    Vector3 hitDirection = new Vector3();

    void Start()
    {
        attackRange = GameManager.Instance.weaponRange;
        cooldown = GameObject.Find("AttackCooldown").GetComponent<Image>();

        attackCooldown = (100f - GameManager.Instance.attackCooldown) / 50f;
        print(attackCooldown);

    }


    // Update is called once per frame
    void Update()
    {
        updateCooldown(); // updates current cooldown on attack

        if (!attackReady)
        {
            cooldownTimer -= Time.deltaTime;
            if(cooldownTimer <= 0)
            {
                attackReady = true;
            }
        }
    }

    public void Attack() // ATTACKING CODE HERE
    {
        if (attackReady)
        {
            print("attack!");
            // Play attack animation

            // Detect enemies in range
            Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
            //print(hitEnemies);

            // Damage enemies
            foreach (Collider enemy in hitEnemies)
            {

                if (enemy.tag == "Door") // Attacking doors
                {
                    print("hitting Door");
                    enemy.GetComponent<DoorScript>().TakeDamage(GameManager.Instance.weaponDamage);
                }
                else
                {
                    //apply damage
                    print("hit " + enemy.name);
                    enemy.GetComponent<BasicEnemy>().TakeDamage(GameManager.Instance.weaponDamage);

                    //apply damage to doors

                    // ADD KNOCKBACK
                    hitDirection = enemy.transform.position - GameObject.FindWithTag("Player").transform.position; // Calculates angle between player and enemy
                    enemy.GetComponent<Rigidbody>().AddForce(hitDirection.normalized * GameManager.Instance.weaponKnockback, ForceMode.Impulse); // Knocks enemy away is specified direction

                }
            }
            //cooldownTimer = GameManager.Instance.attackCooldown;
            cooldownTimer = attackCooldown;
            attackReady = false;
        }
    }

    private void updateCooldown()
    {
        //cooldownPercent = cooldownTimer / GameManager.Instance.attackCooldown;
        cooldownPercent = cooldownTimer / attackCooldown;
        cooldown.fillAmount = cooldownPercent;

        if (invuln)
        {
            invulnTimer -= Time.deltaTime;
            if (invulnTimer <= 0)
            {
                GameManager.Instance.invuln = false;
                invuln = false;
                print("Vulnerable");
            }
        }
    }

    // Displays targeted area of effect
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    public void setInvuln()
    {
        if (!invuln)
        {
            GameManager.Instance.invuln = true;
            invuln = true;
            print("Invulnerable");
            invulnTimer = invulnTime;
        }

    }
}
