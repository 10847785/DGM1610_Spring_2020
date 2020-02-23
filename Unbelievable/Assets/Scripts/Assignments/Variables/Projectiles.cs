using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public GameObject Player;
    public GameObject EnemyDeath;
    public GameObject ProjectileParticle;
    public int PointsToKill;
    public float Speed;
    public int TimeOut;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");

        EnemyDeath = Resources.Load("Prefab/Death Particle") as GameObject;
        ProjectileParticle = Resources.Load("Prefab/Projectile") as GameObject;

        if(Player.transform.localScale. x < 0)
            Speed = -Speed;
        Destroy(gameObject, TimeOut);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(Speed, GetComponent<Rigidbody>().velocity.y);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            ScoreManager.AddPoints(PointsToKill);
        }

        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == null)
        {
            Instantiate(ProjectileParticle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            print("Hit Player");
        }
    }
}
