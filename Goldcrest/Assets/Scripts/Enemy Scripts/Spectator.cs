using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spectator : MonoBehaviour
{

    private Animator anim;

    private int randomNum;

    private float animTimer = 1;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); // Gets reference to the animator component

    }

    // Update is called once per frame
    void Update()
    {
        manageTimer();
    }

    void PlayAnimation()
    {
        print("Picking random animation");
        randomNum = Random.Range(0, 4); // Picks a random number to play a random attack animation

        if (randomNum == 0)
        {
            anim.Play("Sitting Cheer");
        }
        if (randomNum == 1)
        {
            anim.Play("Sitting Clap");
        }
        if (randomNum == 2)
        {
            anim.Play("Stand to Cheer");
        }
        if (randomNum == 3)
        {
            anim.Play("Stand to Clap");
        }

        animTimer = Random.Range(5, 7);
    }

    private void manageTimer()
    {
        animTimer -= Time.deltaTime;

        if (animTimer <= 0)
        {
            print("starting animation");
            PlayAnimation();
        }
    }
}
