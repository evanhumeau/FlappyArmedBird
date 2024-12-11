using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelChanging : MonoBehaviour
{
    [SerializeField] MeshFilter characterMeshFilter;
    [SerializeField] Mesh iddleMesh;
    [SerializeField] Mesh jumpingMesh;

    private PlayerMotor _pm;
    private GameObject _pmObject;


    void Start()
    {
        _pmObject = GameObject.Find("MainChar");
        _pm = _pmObject.GetComponent<PlayerMotor>();

        characterMeshFilter.mesh = iddleMesh;
    }

    // Update is called once per frame
    void Update()
    {
        if(_pm.isJumping == true) 
        {
            characterMeshFilter.mesh = jumpingMesh;
        }
        else
        {
            characterMeshFilter.mesh = iddleMesh;
        }
    }
}
