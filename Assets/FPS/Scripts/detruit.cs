using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detruit : MonoBehaviour
{
    public GameObject door;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(gameObject);
            Destroy(door);  
        }
    }
    
}
