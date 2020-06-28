using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public PlayerCombat playercombat;

    private Vector2 beginTouchPosition, endTouchPosition;
    private int dodgeTime = 250; //TIMER MUST BE LESS THAN THIS TO DODGE
    private int tapTime = 125; // TIMER MUST BE LESS THAN THIS TO TAP

    public Rigidbody rb;
    private Vector3 moveDirection;
    private Vector3 rotateDir;

    Stopwatch timer = new Stopwatch(); // Our stopwatch used for detecting duration of each touch, used for to determine swipe, tap and drag

    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        timer = new Stopwatch();

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   

        if (Input.touchCount > 0) // Detects when screen is touched
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
                        playercombat.Attack();
                        //print("TAP");
                        timer.Reset();
                    }
                        
                    // DETECTS IF INPUT WAS A SWIPE
                    else if (beginTouchPosition != endTouchPosition && fingerDownTime < dodgeTime)
                    {
                        //roll NEEDS WORK! ADD CAP TO DODGE SPEED

                        //converts 2D touch input to 3D direction and launches player
                        touchDistance.z = touchDistance.y;
                        touchDistance.y = 0;
                        GetComponent<Rigidbody>().AddForce(touchDistance / fingerDownTime * GameManager.Instance.dodgeForce);

                        transform.LookAt(touchDistance / fingerDownTime); // ROTATE PLAYER TOWARDS ROLL DIRECTION (Doesn't always work)

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
                // WORK IN PROGRESS STUFF USING RIGIDBODY

                //moveDirection = touch.deltaPosition;
                //moveDirection.y = 0;
                //moveDirection.z = touch.deltaPosition.y;

                //rb.MovePosition(moveDirection * Time.deltaTime);
                //rb.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z);


            // THIS STUFF WORKS, FOLLOWS FINGER

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
                    
                transform.position = Vector3.MoveTowards(transform.position, ray.GetPoint(dist), Time.deltaTime * GameManager.Instance.moveSpeed);
                    GameManager.Instance.isMoving = true;

                    transform.LookAt(ray.GetPoint(dist)); // ROTATE PLAYER TOWARDS MOVEMENT DIRECTION
                }
            }
       }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), "Gold Stored : " + GameManager.Instance.totalCoins);
    }
}
