using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); // Gets reference to the animator component
    }

    // Update is called once per frame
    void Update()
    {
        // Manages run vs idle stances
        if (GameManager.Instance.isMoving)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
        // Manages the attacking animation
        if (GameManager.Instance.isAttacking)
        {
            anim.Play("Attack"); // anim.Play runs the animation once
            GameManager.Instance.isAttacking = false;
        }
        // Manages the dodging animation
        if (GameManager.Instance.isDodging)
        {
            anim.Play("Roll");
            GameManager.Instance.isDodging = false;
        }
    
    }
}
