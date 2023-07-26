using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float InputHorizotal;
    public float speed = 10f;
    public float Xrange ;
    public GameObject foodPrefeb;
    public float shotTime, delayTime;
    void Start()
    {
        
    }

    void Update()
    {
        InputHorizotal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * InputHorizotal * Time.deltaTime);

        if(transform.position.x < -Xrange)
        transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);

        if (transform.position.x > Xrange)
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);

        if (Time.time > shotTime + delayTime) // ∑Œ ¥Î√º 

        {

            Instantiate(foodPrefeb, transform.position,

            foodPrefeb.transform.rotation);

            shotTime = Time.time;
        }
    }
}
