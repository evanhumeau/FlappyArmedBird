using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour
{

    [SerializeField]
    private GameObject replay;
    [SerializeField]
    private GameObject play;
    [SerializeField]
    private GameObject gover;
    [SerializeField]
    private GameObject goverSound;

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
            Instantiate(goverSound);
            Destroy(gameObject);
            _gm.Pause();
            play.SetActive(false);
            replay.SetActive(true);
            gover.SetActive(true);
            

        } else if (other.CompareTag("Wall"))
            {
            Instantiate(goverSound);
            Destroy(gameObject);
                _gm.Pause();
            play.SetActive(false);
            replay.SetActive(true);
            gover.SetActive(true);
            

        }
    }
}
