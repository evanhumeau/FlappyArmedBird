using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDump : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pipe")
        {
            Destroy(other.gameObject);
        }
    }
}
