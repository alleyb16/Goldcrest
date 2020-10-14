using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 5f;
    public float speed = 1.5f;

    public GameObject wanderPoint;

    private bool _alive;
    private bool _wander;
    Stopwatch timer = new Stopwatch(); 
    private Vector3 target;
    NavMeshAgent agent;


    //Ray ray = new Ray();
    //RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        timer = new Stopwatch(); // Timer for wandering enemies
        _wander = true;
        _alive = false;
        
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {








        // Wandering state
        if (_wander)
        {
            speed = 1.0f;
            timer.Start();
            //if (Physics.SphereCast(ray, 0.75f, out hit))
            //{
            transform.position = Vector3.MoveTowards(transform.position, wanderPoint.transform.position, Time.deltaTime * 1);
            while (timer.ElapsedMilliseconds >= 2000)
                {
                    //if (hit.distance < lookRadius)
                    //{
                        float angle = Random.Range(-360, 360);
                        transform.Rotate(0, angle, 0);
               
                //transform.position += transform.forward * Time.deltaTime * 50;
                //transform.Translate(Vector3.forward * Time.deltaTime);
                timer.Reset();
                    //}
                }

            }
        //}
        // Chasing state
        if (_alive)
        {
            target = PlayerManager.instance.player.transform.position;
            Vector3 goal = new Vector3(target.x - 1, target.y, target.z - 1);
            transform.position = Vector3.MoveTowards(transform.position, goal, Time.deltaTime * 3);
            transform.LookAt(target); // ROTATE ENEMY TOWARDS MOVEMENT DIRECTION



            /* float distance = Vector3.Distance(target.position, transform.position);
             if (distance <= lookRadius)
             {
                 Vector3 goal = new Vector3(target.position.x - 1, target.position.y, target.position.z - 1);
                 transform.LookAt(target);
                 agent.SetDestination(goal);

             }
         }*/
        }

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {

                print("I'm coming for you");
                _alive = true;
                _wander = false;
       
            
                print("I see you");
                transform.Translate(0, 0, speed * Time.deltaTime); // Speed of enemy movement
            

            //Ray ray = new Ray(transform.position, transform.forward); // Raycast checking to see if enemy is within sight radius
            //RaycastHit hit;
            //    _wander = true;
        }






    }
    private void OnDrawGizmosSelected()
        {
            // Shows enemies sight radius
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, lookRadius);
        }
        public void SetAlive(bool alive) {
            _alive = alive;
        }
}
