using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telegram : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 20;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
