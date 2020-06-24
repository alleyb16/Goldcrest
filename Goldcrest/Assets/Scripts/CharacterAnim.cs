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
    
    }
}
