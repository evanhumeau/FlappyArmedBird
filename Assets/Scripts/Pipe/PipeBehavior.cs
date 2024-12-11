using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehavior : MonoBehaviour
{
    [SerializeField]
    private float pipeSpeed = 4f;
    [SerializeField]
    private float minPipeSpeed = 4f;
    [SerializeField]
    private float maxPipeSpeed = 8f;

    private GameManager _gm;
    private GameObject _gmObject;

    //Private

    private int x;
    private int y; 

    void Start()
    {
        _gmObject = GameObject.Find("GameManager");
        _gm = _gmObject.GetComponent<GameManager>();


        if (_gm.score <= 5)
        {
            pipeSpeed = minPipeSpeed;
        }
        else if (_gm.score >= 6 && _gm.score <= 15)
        {
            //pipeSpeed = (maxPipeSpeed - minPipeSpeed)/2 + minPipeSpeed;
            pipeSpeed = minPipeSpeed + 1;
        }
        else if (_gm.score >= 16 && _gm.score <= 50)
        {
            pipeSpeed = minPipeSpeed + 3;
        }
        else if (_gm.score >= 51)
        {
            pipeSpeed = maxPipeSpeed;
        }


        x = 23;
        y = Random.Range(-5, 5);

        transform.position = new Vector3(x, y, 0);
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x - pipeSpeed * Time.deltaTime, transform.position.y, 0);
    }
}
