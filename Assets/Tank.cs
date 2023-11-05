using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;
    public float rotateSpeed = 90;

    void Update()
    {

        var ver = Input.GetAxis("Vertical");
        transform.position += transform.forward * speed * ver * Time.deltaTime;

        var hor = Input.GetAxis("Horizontal");
        transform.Rotate(0,rotateSpeed * hor * Time.deltaTime,0);
    }
}