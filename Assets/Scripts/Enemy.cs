using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    //Agregando un comentario

    // Use this for initialization
    void Start ()
    {
        
    }
    
    // Update is called once per frame
    void Update ()
    {
        
        transform.position += transform.up * speed * Time.deltaTime;
    }

    private void OnBecameInvisible()
    {
        GameObject.Destroy(gameObject);
    }
    
    

    public void OnRecibirDano(float cantidad)
    {
        Debug.Log("Ouch!! Me hicieron " + cantidad + " de daño!!");
        GameObject.Destroy(gameObject);
    }

}
