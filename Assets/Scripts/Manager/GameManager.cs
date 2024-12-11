using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public bool isPaused;

    private void Awake()
    {
        score = 0;
        Pause();
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void Play()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }
    void Update()
    {

    }
}
