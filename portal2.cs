using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal2 : MonoBehaviour
{

    public Transform teleportPoint;
    
        
    

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportPoint.position;
    }
}
