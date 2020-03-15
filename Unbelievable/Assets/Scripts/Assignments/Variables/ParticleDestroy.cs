using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour
{
    private ParticleSystem DestroyParticles;

    // Start is called before the first frame update
    void Start()
    {

        DestroyParticles = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyParticles.isEmitting)
            return;

       // GameObject Kill = (GameObject)Instantiate(transform.position, transform.rotation);

        Destroy(gameObject);

    }
}
