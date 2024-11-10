using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject pipes;

    //Privates

    private int _spawnInterval = 5;

  
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Instantiate(pipes);

            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}
