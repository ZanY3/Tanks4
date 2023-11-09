using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public AudioSource hitSource;

    void Start()
    {
        Destroy(gameObject,2f);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Contains("Boom"))
        {
            hitSource.Play();
            collision.gameObject.GetComponent<Health>().health -= 1;
            collision.gameObject.GetComponent<Health>().Die();

        }
        if(collision.gameObject.tag.Contains("Player"))
        {
            collision.gameObject.GetComponent<Health>().health -= 1;
            collision.gameObject.GetComponent<Health>().Die();
        }
        Destroy(gameObject);
    }
    
}