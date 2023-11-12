using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject particle;
    public float partCount;
    public float health = 3;
    public AudioSource source;
    public void Die()
    {
        if (health == 0)
        {

            for (int i = 0; i < partCount; i++)
            {
                source.Play();
                Destroy(gameObject);
                var offset = Random.insideUnitSphere;
                Instantiate(particle, transform.position + offset, transform.rotation);
            }
        }
    }   
}
