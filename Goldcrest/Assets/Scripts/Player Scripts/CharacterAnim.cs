using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator anim;

    private int randomNum;

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
            anim.SetBool("isWalking", false);
        }
        if (GameManager.Instance.isWalking)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isMoving", false);
        }
        if (!GameManager.Instance.isWalking && !GameManager.Instance.isMoving)
        {
            anim.SetBool("isMoving", false);
            anim.SetBool("isWalking", false);
        }
        // Manages the attacking animation
        if (GameManager.Instance.isAttacking)
        {
            if (GameManager.Instance.SwordT1 || GameManager.Instance.SwordT2 || GameManager.Instance.SwordT3) // ANIMATIONS FOR SWORD
            {
                if (!GameManager.Instance.isMoving && !GameManager.Instance.isWalking)
                {
                    randomNum = Random.Range(0, 3); // Picks a random number to play a random attack animation

                    if (randomNum == 0)
                    {
                        anim.Play("Attack"); // anim.Play runs the animation once
                        print("attack 1 " + randomNum);
                    }
                    if (randomNum == 1)
                    {
                        anim.Play("Attack 2");
                        print("attack 2 " + randomNum);
                    }
                    if (randomNum == 2)
                    {
                        anim.Play("Attack 3");
                    }

                    FindObjectOfType<AudioManager>().Play("WeaponAttack"); // Play attack sound
                    GameManager.Instance.isAttacking = false;

                }
                if (GameManager.Instance.isMoving||GameManager.Instance.isWalking) // moving animations for sword
                {
                    randomNum = Random.Range(0, 2); // Picks a random number to play a random attack animation

                    if (randomNum == 0) // Play Yeetus 1 if 0
                    {
                        anim.Play("Yeetus");
                    }
                    if (randomNum == 1) // Play Yeetus 2 if 1
                    {
                        anim.Play("Yeetus 2");
                    }
                    FindObjectOfType<AudioManager>().Play("WeaponAttack"); // Play attack sound
                    GameManager.Instance.isAttacking = false;
                }
            }

            if (GameManager.Instance.AxeT1 || GameManager.Instance.AxeT2 || GameManager.Instance.AxeT3) // ANIMATIONS FOR AXE
            {
                if (!GameManager.Instance.isMoving && !GameManager.Instance.isWalking)
                {
                    randomNum = Random.Range(0, 3); // Picks a random number to play a random attack animation

                    if (randomNum == 0)
                    {
                        anim.Play("Attack"); // anim.Play runs the animation once
                        print("attack 1 " + randomNum);
                    }
                    if (randomNum == 1)
                    {
                        anim.Play("Attack 2");
                        print("attack 2 " + randomNum);
                    }
                    if (randomNum == 2)
                    {
                        anim.Play("Attack 3");
                    }
                    FindObjectOfType<AudioManager>().Play("WeaponAttack"); // Play attack sound

                    GameManager.Instance.isAttacking = false;
                }
                if (GameManager.Instance.isMoving || GameManager.Instance.isWalking) // moving animations for axe
                {
                    randomNum = Random.Range(0, 2); // Picks a random number to play a random attack animation

                    if (randomNum == 0) // Play Yeetus 1 if 0
                    {
                        anim.Play("Yeetus");
                    }
                    if (randomNum == 1) // Play Yeetus 2 if 1
                    {
                        anim.Play("Yeetus 2");
                    }
                    FindObjectOfType<AudioManager>().Play("WeaponAttack"); // Play attack sound

                    GameManager.Instance.isAttacking = false;
                }
            }
            if (GameManager.Instance.SpearT1 || GameManager.Instance.SpearT2 || GameManager.Instance.SpearT3) // ANIMATIONS FOR SPEAR
            {
                if (!GameManager.Instance.isMoving && !GameManager.Instance.isWalking)
                {          
                        anim.Play("Spear Stab");
                }
                if (GameManager.Instance.isMoving || GameManager.Instance.isWalking) // moving animations for spear
                {
                    randomNum = Random.Range(0, 2); // Picks a random number to play a random attack animation

                    if (randomNum == 0) // Play Yeetus 1 if 0
                    {
                        anim.Play("Yeetus");
                    }
                    if (randomNum == 1) // Play Yeetus 2 if 1
                    {
                        anim.Play("Yeetus 2");
                    }
                }
                FindObjectOfType<AudioManager>().Play("WeaponAttack"); // Play attack sound

                GameManager.Instance.isAttacking = false;
            }
        }
        // Manages the dodging animation
        if (GameManager.Instance.isDodging)
        {
            if (GameManager.Instance.ClothT1 || GameManager.Instance.ClothT2 || GameManager.Instance.ClothT3)
            {
                anim.Play("Roll");
                FindObjectOfType<AudioManager>().Play("ClothRoll");
            }
            if (GameManager.Instance.LeatherT1 || GameManager.Instance.LeatherT2 || GameManager.Instance.LeatherT3)
            {
                anim.Play("Slide");
                FindObjectOfType<AudioManager>().Play("LeatherSlide");

            }
            if (GameManager.Instance.PlateT1 || GameManager.Instance.PlateT2 || GameManager.Instance.PlateT3)
            {
                anim.Play("Dive");
                FindObjectOfType<AudioManager>().Play("PlateDodge");
            }

            GameManager.Instance.isDodging = false;
        }

        // Plays drink animation
        if (GameManager.Instance.isDrinking)
        {
            anim.Play("Drink");
            //GameManager.Instance.isDrinking = false;
        }
    
        if (GameManager.Instance.isDead)
        {
            anim.Play("Death");
        }
    }
}
