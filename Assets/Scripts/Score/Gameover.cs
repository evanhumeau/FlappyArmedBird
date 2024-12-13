using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour
{
    [SerializeField]
    private GameObject goverUI;
    [SerializeField]
    private GameObject goverSound;

    [SerializeField]
    private Transform explosionTransform;


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
            goverSound.SetActive(true);
            explosionTransform.parent = null;
            Destroy(gameObject);
            _gm.Pause();
            goverUI.SetActive(true);
            

        } else if (other.CompareTag("Wall"))
            {
            goverSound.SetActive(true);
            explosionTransform.parent = null;
            Destroy(gameObject);
                _gm.Pause();
            goverUI.SetActive(true);



        }
    }
}
