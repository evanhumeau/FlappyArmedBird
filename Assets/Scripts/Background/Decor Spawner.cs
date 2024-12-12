using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject decor1;
    [SerializeField]
    private GameObject decor2;
    [SerializeField]
    private GameObject decor3;
    [SerializeField]
    private GameObject decor4;

    //Privates

    private int _spawnInterval1 = 6;



    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        
            Instantiate(decor1);

            yield return new WaitForSeconds(_spawnInterval1);

        Instantiate(decor2);

        yield return new WaitForSeconds(_spawnInterval1);

        Instantiate(decor3);

        yield return new WaitForSeconds(_spawnInterval1);

        Instantiate(decor4);



    }
}
