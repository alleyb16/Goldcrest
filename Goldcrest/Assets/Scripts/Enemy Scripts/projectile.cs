using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float bulletDamage = 10; // How much damage bullet does to player
    public float bulletLifespan = 3; // How long the bullet exists in the scene

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(onDeath), bulletLifespan);
        target = GameObject.FindWithTag("Player").transform;
        transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void onDeath()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other) // Damages player if the projectile collides
    {
        if (other.CompareTag("Player") && GameManager.Instance.invuln == false)
        {
            GameManager.Instance.playerHealth -= bulletDamage;
            FindObjectOfType<AudioManager>().Play("PlayerShot");
            Destroy(gameObject);
            // KNOCKBACK ON PLAYER (DOESN'T WORK RN)
            //hitDirection = player.transform.position - transform.position; // Calculates angle between player and enemy
            //player.GetComponent<Rigidbody>().AddForce(hitDirection.normalized * 50, ForceMode.Impulse); // Knocks enemy away is specified direction
        }
    }
}
