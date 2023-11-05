using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}