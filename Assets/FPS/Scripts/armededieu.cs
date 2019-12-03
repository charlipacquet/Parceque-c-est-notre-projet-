using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armededieu : MonoBehaviour
{
    public GameObject piececaché;
    void Update()
    {
        if(Input.GetKey(KeyCode.Y))
        {
            Destroy(piececaché);
        }
    }
}
