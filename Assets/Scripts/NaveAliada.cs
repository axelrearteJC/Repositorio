using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveAliada : MonoBehaviour
{
    public float speed;
    public GameObject prefab;
    //float accelx, accely, accelz = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = 1f;

        
        /*
        if (Input.GetKey(KeyCode.W))
        {
            accelx = Input.acceleration.x * Time.deltaTime;
            transform.Rotate(accelx * Time.deltaTime, accely * Time.deltaTime, accelz * Time.deltaTime);
        }
        */

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * 2);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 2);
        }

        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime;
            transform.position += transform.up * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime;
            transform.position -= transform.up * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject nuevaBala = GameObject.Instantiate(prefab);
            nuevaBala.transform.position = transform.position;
            nuevaBala.transform.rotation = transform.rotation;
            nuevaBala.layer = gameObject.layer;
        }

        /*

        if (Input.GetKey(KeyCode.UpArrow))
        { 
        transform.position += Vector3.up * speed  * Time.deltaTime;

        }else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
           GameObject nuevaBala = GameObject.Instantiate(prefab);
            nuevaBala.transform.position = transform.position;
        }
        */
    }
}
