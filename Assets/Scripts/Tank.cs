using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;
    public float rotateSpeed = 90;

    public string vertical;
    public string horizontal;
    public KeyCode shootKey;

    public GameObject bullet;
    public Transform shootPoint;
    public AudioSource shootSource;

    void Update()
    {

        var ver = Input.GetAxis(vertical);
        //transform.position += transform.forward * speed * ver * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = transform.forward * speed * ver;

        var hor = Input.GetAxis(horizontal);
        transform.Rotate(0, rotateSpeed * hor * Time.deltaTime, 0);

        if (Input.GetKeyDown(shootKey))
        {
            shootSource.Play();
            //print("Boom !!!");
            Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        }

    }
}