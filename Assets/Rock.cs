using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public GameObject part;
    public Transform partPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(part, partPoint.position, partPoint.rotation);
        Instantiate(part, partPoint.position, partPoint.rotation);
        Instantiate(part, partPoint.position, partPoint.rotation);
    }
}
