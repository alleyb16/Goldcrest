using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public PlayerCombat playercombat;

    public Joystick joystick;

    private float dodgeCooldownTimer;
    private float dodgeCooldown = 1.5f;
    public bool dodgeReady = true;
    private float cooldownPercent;

    public float moveSpeed = 5f;

    public Image cooldownIMG;
    //private Vector2 beginTouchPosition, endTouchPosition;
    //private int dodgeTime = 250; //TIMER MUST BE LESS THAN THIS TO DODGE
    //private int tapTime = 125; // TIMER MUST BE LESS THAN THIS TO TAP

    public Rigidbody rb;
    //private Vector3 moveDirection;
    //private Vector3 rotateDir;

   // Stopwatch timer = new Stopwatch(); // Our stopwatch used for detecting duration of each touch, used for to determine swipe, tap and drag

    public Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        //timer = new Stopwatch();
        cooldownIMG = GameObject.Find("DodgeCooldown").GetComponent<Image>();

        moveSpeed = GameManager.Instance.moveSpeed;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        updateCooldown();

        if (!dodgeReady)
        {
            dodgeCooldownTimer -= Time.deltaTime;
            if(dodgeCooldownTimer <= 0f)
            {
                dodgeReady = true;
            }
        }

        // Old Trash
        #region
        /*  if (Input.touchCount > 0) // Detects when screen is touched
          {
             Touch touch = Input.GetTouch(0); // Looks at first touch from the touch index

              switch (touch.phase)
              {
                  case TouchPhase.Began: // RUNS WHEN FINGER IS PRESSED
                      beginTouchPosition = touch.position;
                      timer.Start();//START TIMER

                      break;


                  case TouchPhase.Ended: //RUNS WHEN FINGER IS LIFTED
                      endTouchPosition = touch.position;
                      timer.Stop(); //END TIMER
                      long fingerDownTime = timer.ElapsedMilliseconds; //Stores touch duration

                      GameManager.Instance.isMoving = false;

                      // DETECT DISTANCE IN SWIPE
                      Vector3 touchDistance = new Vector3();
                      touchDistance = endTouchPosition - beginTouchPosition;


                      // DETECTS IF INPUT WAS A TAP
                      if (beginTouchPosition == endTouchPosition && fingerDownTime < tapTime)
                      {
                          //attack
                          if (GameManager.Instance.isAttacking == false)
                          {
                              playercombat.Attack();
                              GameManager.Instance.isAttacking = true;
                          }
                          //print("TAP");
                          timer.Reset();
                      }

                      // DETECTS IF INPUT WAS A SWIPE
                      else if (beginTouchPosition != endTouchPosition && fingerDownTime < dodgeTime)
                      {
                          if (GameManager.Instance.isDodging == false)
                          {

                              GetComponent<Rigidbody>().drag = 1;
                              //roll NEEDS WORK! ADD CAP TO DODGE SPEED

                              //converts 2D touch input to 3D direction and launches player
                              touchDistance.z = touchDistance.y;
                              touchDistance.y = 0;
                              GetComponent<Rigidbody>().AddForce(touchDistance / fingerDownTime * GameManager.Instance.dodgeForce);

                              GameManager.Instance.isDodging = true;


                          }

                          print("SWIPE");
                          timer.Reset();
                      }

                      // IF INPUT IS NEITHER TAP NOR SWIPE
                      else
                      {
                          timer.Reset();
                      }

                      break;

              }

              // MOVES PLAYER TO FOLLOW FINGER
              if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {

              //  FOLLOWS FINGER

                  Plane plane = new Plane(Vector3.up, transform.position);

                  Ray ray = cam.ScreenPointToRay(Input.mousePosition); // Sends ray from camera view to position of finger, detects world location of the ray and moves players towards it

                  float dist;
                  if(plane.Raycast (ray, out dist))
                  {
                      //POSSIBLY MOVE PLAYER SLOWER WHEN FINGER IS PRESSED NEARBY
                      //if ()
                      // {
                      //     GameManager.Instance.moveSpeed = 2f;
                      // }

                      //rb.position = Vector3.MoveTowards(transform.position, ray.GetPoint(dist), Time.deltaTime * GameManager.Instance.moveSpeed);
                      transform.position = Vector3.MoveTowards(transform.position, ray.GetPoint(dist), Time.deltaTime * GameManager.Instance.moveSpeed);
                      GameManager.Instance.isMoving = true;

                      transform.LookAt(ray.GetPoint(dist)); // ROTATE PLAYER TOWARDS MOVEMENT DIRECTION
                  }
              }
         }*/
        #endregion
    }

    void movePlayer()
    {
        var rigidbody = GetComponent<Rigidbody>();

        if (!GameManager.Instance.isDrinking)
        {

            if (joystick.Horizontal >= 0.1f || joystick.Vertical >= 0.1f || joystick.Horizontal <= -0.1f || joystick.Vertical <= -.01f)
            {
                float hor = joystick.Horizontal;
                float ver = joystick.Vertical;
                Vector3 movement = new Vector3(hor, 0f, ver) * moveSpeed * Time.deltaTime; // Calculates movement direction
                transform.Translate(movement, Space.World); // Moves player

                //ROTATION
                float targetAngle = Mathf.Atan2(hor, ver) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0f, targetAngle, 0f).normalized;

                GameManager.Instance.isMoving = true;
            }
            else
            {
                GameManager.Instance.isMoving = false;
            }
        }
    }

    public void attack()
    {
        if (!GameManager.Instance.isDrinking)
        {
            //attack
            if (playercombat.attackReady)
            {
                GameManager.Instance.isAttacking = true;
                playercombat.Attack();
            }
        }
    }

    public void startDodge()
    {
        if (!GameManager.Instance.isDrinking)
        {
            if (dodgeReady)
            {
                GameManager.Instance.isDodging = true;
                playercombat.setInvuln();
                rb.AddForce(transform.forward * GameManager.Instance.dodgeForce * 2);
                dodgeCooldownTimer = dodgeCooldown;
                dodgeReady = false;
            }
        }
    }

    private void updateCooldown()
    {
        cooldownPercent = dodgeCooldownTimer / dodgeCooldown;
        cooldownIMG.fillAmount = cooldownPercent;
    }
}
