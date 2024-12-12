using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public bool isPaused;

    [SerializeField]
    private GameObject canva;


    private void Awake()
    {
        score = 0;
        Pause();
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
        canva.SetActive(true);
    }

    public void Play()
    {
        isPaused = false;
        Time.timeScale = 1f;
        canva.SetActive(false);
    }
    public void Replay()
    {
        SceneManager.LoadScene("Level1");
    }
    void Update()
    {

    }
}
