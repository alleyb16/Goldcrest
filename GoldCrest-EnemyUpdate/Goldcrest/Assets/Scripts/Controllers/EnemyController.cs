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
    private bool _alive;
    private bool _wander;
    Stopwatch timer = new Stopwatch(); 
    Transform target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        timer = new Stopwatch();
        _wander = true;
        _alive = true;
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (_wander)
        {
            speed = 1.0f;
            timer.Start();
            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                while (timer.ElapsedMilliseconds >= 2000)
                {
                    if (hit.distance < lookRadius)
                    {
                        float angle = Random.Range(-360, 360);
                        transform.Rotate(0, angle, 0);
                        timer.Reset();
                    }
                }
                
            }
        }
        if (_alive)
        {
            float distance = Vector3.Distance(target.position, transform.position);
            if (distance <= lookRadius)
            {
                Vector3 goal = new Vector3(target.position.x-1, target.position.y, target.position.z-1);
                transform.LookAt(target);
                agent.SetDestination(goal);
                _wander = false;
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
    public void SetAlive(bool alive){
        _alive = alive;
    }
}
