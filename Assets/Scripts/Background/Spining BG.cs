using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiningBG : MonoBehaviour
{
    private float speed; 
    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, speed * Time.deltaTime, 0f, Space.Self); 
    }
}
