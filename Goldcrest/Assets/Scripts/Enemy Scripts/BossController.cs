using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.AI;

public class BossController : MonoBehaviour
{
    //public float lookRadius = 5f;
    //public float speed = 1.5f;

    public GameObject wanderPoint;

    //private bool _alive;
    //private bool _wander;
    //Stopwatch timer = new Stopwatch();
    //private Vector3 target;
    public NavMeshAgent agent;

    //New Stuff Misc
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;

    //New Stuff Patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //New Stuff Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject projectile;
    public GameObject projectile2;
    public float projectileSpeed = 25f;

    //New Stuff States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;
    public bool isRunning;
    //Animation State
    private Animator anim;
    public BasicEnemy enemy;

    private int randomNum;


    //New Stuff Awake
    private void Awake()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();

    }
    //New Update
    private void Update()
    {

        //Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        //if (!playerInSightRange && !playerInAttackRange) Patroling();
        if (enemy.currentHealth >= 400)
        {
            if (playerInSightRange && !playerInAttackRange)
            {
                anim.SetBool("atk", false);
                anim.SetBool("run", true);
                isRunning = true;
                ChasePlayer();
            }
            if (playerInSightRange && playerInAttackRange)
            {
                anim.SetBool("run", false);
                AttackPlayer();
            }
        }
        if (enemy.currentHealth < 400)
        {
            if (playerInSightRange && !playerInAttackRange)
            {
                anim.SetBool("atk2", false);
                anim.SetBool("run", true);
                ChasePlayer();
            }
            if (playerInSightRange && playerInAttackRange)
            {
                anim.SetBool("run", false);
                AttackPhase2();
            }
        }
    }
    
    //New Stuff Patroling
    private void Patroling()
    {
        if (!walkPointSet) searchWalkPoint();

        if (walkPointSet)
        {
            agent.SetDestination(walkPoint);
        }
        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint Reached
        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }
    }

    //New Stuff Walkpoint
    private void searchWalkPoint()
    {
        //Creates random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomx = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomx, transform.position.z + randomZ);
        walkPointSet = true;
        //uses raycast to makesure that the point is on the ground and in the map
        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
        {
            walkPointSet = true;
        }

    }

    //New Stuff Chase Player
    private void ChasePlayer()
    {
        if (!enemy.isDead)
            agent.SetDestination(player.position);
    }

    //New Stuff Attack Player
    private void AttackPlayer()
    {
        //Make sure enemy doesn't move
        agent.SetDestination(transform.position);

        transform.LookAt(player); // makes enemy face player

        if (!alreadyAttacked)
        {
            if (gameObject.tag == "Mini Boss") // Boss attacks
            {
                randomNum = Random.Range(0, 2); // Picks a random number to play a random attack animation

                if (randomNum == 0)
                {
                    anim.Play("attack");
                }
                if (randomNum == 1)
                {
                    anim.Play("attack 2");
                }
            }
            Invoke(nameof(fire), 1.25f); // queues the attack projectile

            alreadyAttacked = true; // sets the attacked state to true
            Invoke(nameof(ResetAttack), timeBetweenAttacks); // Sets attacked state to false after a delay
        }
    }
    private void AttackPhase2()
    {
        agent.SetDestination(transform.position);

        transform.LookAt(player); // makes enemy face player

        if (!alreadyAttacked)
        {
            if (gameObject.tag == "Mini Boss") // Boss attacks
            {
                randomNum = Random.Range(0, 2); // Picks a random number to play a random attack animation

                if (randomNum == 0)
                {
                    anim.SetBool("atk2", true);
                    anim.Play("attack 3");
                    
                }
                if (randomNum == 1)
                {
                    anim.SetBool("atk2", true);
                    anim.Play("attack 4");
                }
            }
            if (randomNum == 0)
            {
                Invoke(nameof(fire2), 0.60f);
                Invoke(nameof(fire2), 0.85f);
                Invoke(nameof(fire2), 1.00f);
                Invoke(nameof(fire2), 1.15f);
                Invoke(nameof(fire2), 1.30f);
                Invoke(nameof(fire2), 1.45f);
                Invoke(nameof(fire2), 1.60f);
                Invoke(nameof(fire2), 1.85f);
                Invoke(nameof(fire2), 2.00f);
                print("Firing");
            }
            else
            {
                Invoke(nameof(fire), 1.25f); // queues the attack projectile
            }
            alreadyAttacked = true; // sets the attacked state to true
            Invoke(nameof(ResetAttack), timeBetweenAttacks); // Sets attacked state to false after a delay
        }
    }
    private void fire() // Fires the projectile
    {
        if (enemy.isDead == false)
        {
            Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * projectileSpeed, ForceMode.Impulse);
            rb.AddForce(transform.up * 5f, ForceMode.Impulse);

            if (gameObject.tag == "Ranger")
            {
                FindObjectOfType<AudioManager>().Play("BowFire");
            }
        }
    }
    private void fire2() // Fires the projectile
    {
        if (enemy.isDead == false)
        {
            Rigidbody rb = Instantiate(projectile2, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * projectileSpeed, ForceMode.Impulse);
            rb.AddForce(transform.up * 5f, ForceMode.Impulse);

            if (gameObject.tag == "Ranger")
            {
                FindObjectOfType<AudioManager>().Play("BowFire");
            }
        }
    }
    //New Stuff Reset Attack
    private void ResetAttack() // Resets the attacked state
    {
        alreadyAttacked = false;
        anim.SetBool("atk2", false);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}

/*Ray ray = new Ray();
RaycastHit hit;
// Start is called before the first frame update

void Start()
{
    timer = new Stopwatch(); // Timer for wandering enemies
    _wander = true;
    _alive = false;

    agent = GetComponent<NavMeshAgent>();
}
*/

/*void Update()
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
     }
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
}/*/

