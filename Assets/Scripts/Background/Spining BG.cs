using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiningBG : MonoBehaviour
{
    private float speed; 
    // Start is called before the first frame update
    void Start()
    {
        speed = 24f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0f , 0f, Space.Self); 
    }
}
