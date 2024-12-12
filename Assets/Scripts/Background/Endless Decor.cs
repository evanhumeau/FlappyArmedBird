using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessDecor : MonoBehaviour
{

    private float decorSpeed; 

    // Start is called before the first frame update
    void Start()
    {
        decorSpeed = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -50f)
        {
            transform.position = new Vector3(transform.position.x - decorSpeed * Time.deltaTime, transform.position.y, 0);
        }
    }
}
