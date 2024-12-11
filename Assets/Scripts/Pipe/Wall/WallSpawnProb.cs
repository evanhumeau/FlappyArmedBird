using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawnProb : MonoBehaviour
{
    //Private 
    private int proba;

    private GameManager _gm;
    private GameObject _gmObject;

    void Start()
    {
        _gmObject = GameObject.Find("GameManager");
        _gm = _gmObject.GetComponent<GameManager>();

        if (_gm.score <= 15)
        {
            proba = Random.Range(0, 4); // 1 chance sur 4 d'apparaitre 
        } else if (_gm.score >= 16 && _gm.score <= 25)
        {
            proba = Random.Range(0, 3); // 1 chance sur 3 d'apparaitre 
        } else if (_gm.score >= 26)
        {
            proba = Random.Range(0, 2); // 1 chance sur 2 d'apparaitre 
        }


        if (proba != 0)
        {
            gameObject.SetActive(false);
        }  
    }
}
