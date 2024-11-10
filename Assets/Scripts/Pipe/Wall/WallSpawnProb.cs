using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawnProb : MonoBehaviour
{
    //Private 

    private int here;

    void Start()
    {
        here = Random.Range(0, 3);
        Debug.Log(here); 

        if (here != 0)
        {
            gameObject.SetActive(false);
        }  
    }
}
