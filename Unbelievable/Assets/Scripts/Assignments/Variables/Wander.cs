using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wander : MonoBehaviour
{
    //Wander
    public float wanderRadius;
    public float wanderTimer;

    public Transform target;
    private NavMeshAgent agent;
    private float timer;

    //Detection
    public float speed;
    public float alertDist;
    public float attackDist;
    private float distance;
    private Vector3 direction;

    // Attact
    public int damage;

    // Use this for initialization
    void OnEnable ()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
    }

    void Start()
    {
        distance = Vector3.Distance(target.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(target.position, transform.position);

        //Alert
        if(distance < alertDist && distance > attackDist)
        {
            print("Enemy sees target");
            speed += 2;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        //Following
        else if(distance <= alertDist)
        {
            print("Enemy is Following");
            direction = target.position - transform.position;
            direction.y = 0;
            speed -= 3;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);


            if(direction.magnitude <= attackDist)
            {
                print("Enemy is attackting");
                var health = target.gameObject.GetComponent<Player_Health>();

                if (health != null)
                {
                    health.TakeDamage(damage);
                }

            }
        }

        //Wandering
        else if(distance > alertDist)
        {
            timer += Time.deltaTime;

            if (timer >= wanderTimer)
            {
                Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                agent.SetDestination(newPos);
                timer = 0;
            }
        }
       

        
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}
