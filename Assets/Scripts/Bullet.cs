using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public float speed;
    
    // Use this for initialization
    void Start ()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        
    }
    
    //Se ejecuta cuando este objeto deja de ser visible por todas las cámaras.
    void OnBecameInvisible()
    {
        GameObject.Destroy(gameObject);
    }

    //Se ejecuta cuando se produce una colisión con este objeto.
    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.SendMessage("OnRecibirDano", damage, SendMessageOptions.DontRequireReceiver);
        GameObject.Destroy(gameObject);
    }
}