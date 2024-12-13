using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public bool isPaused;

    [SerializeField]
    private GameObject playUI;
    [SerializeField]
    private GameObject scoreUI;
    [SerializeField]
    private GameObject titleUI;


    private void Awake()
    {
        score = 0;
        NewGame();
    }

    public void NewGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void Pause()
    {
        isPaused = true;
        StartCoroutine(Replay());
    }

    public void Play()
    {
        isPaused = false;
        Time.timeScale = 1f;
        playUI.SetActive(false);
        scoreUI.SetActive(true); 
        titleUI.SetActive(false);

    }

    IEnumerator Replay()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Level1");
    }
    /*public void Replay()
    {
        SceneManager.LoadScene("Level1");
    }*/
    void Update()
    {

    }
}
