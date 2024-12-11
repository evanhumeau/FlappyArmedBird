using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour
{

    private GameManager _gm;
    private GameObject _gmObject;

    // Start is called before the first frame update
    void Start()
    {
        _gmObject = GameObject.Find("GameManager");
        _gm = _gmObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pipe"))
        {
            Destroy(gameObject);
            _gm.Pause();
        }
    }
}
