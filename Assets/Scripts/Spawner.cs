using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    
    public void Spawn()
    {
        GameObject obj = GameObject.Instantiate(prefab);
        obj.transform.position = transform.position;
        obj.transform.up = transform.up;
    }
}