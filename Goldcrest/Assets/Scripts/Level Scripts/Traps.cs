using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    //private Player player;
    public PlayerCombat playerCombat;
    //Vector3 hitDirection = new Vector3();

    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
    }

    void OnTriggerEnter(Collider col)
    {
        //DAMAGE PLAYER IF CONTACT WITH TRAP
        if (col.CompareTag("Player") && playerCombat.invuln == false)
        {            
                GameManager.Instance.playerHealth -= 20;
            
            // KNOCKBACK ON PLAYER (DOESN'T WORK RN)
            //hitDirection = player.transform.position - transform.position; // Calculates angle between player and enemy
            //player.GetComponent<Rigidbody>().AddForce(hitDirection.normalized * 50, ForceMode.Impulse); // Knocks enemy away is specified direction
        }
    }
}
