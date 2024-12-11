using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour
{

    public Text scoreText;

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
        scoreText.text = "" + _gm.score;
    }
}
