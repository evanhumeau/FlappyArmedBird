using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehavior : MonoBehaviour
{

    //Private

    private int x;
    private int y; 

    void Start()
    {
        x = 23;
        y = Random.Range(-5, 5);

        transform.position = new Vector3(x, y, 0);
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x - 4f * Time.deltaTime, transform.position.y, 0);
    }
}