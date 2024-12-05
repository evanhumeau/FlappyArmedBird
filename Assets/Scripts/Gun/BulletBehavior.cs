using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private float _speed = 60f;

    private void Start()
    {
        StartCoroutine(BulletDestroy());
    }

    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        } else if (other.CompareTag("Pipe"))
        {
            Destroy(gameObject);
        }
    }

    IEnumerator BulletDestroy()
    {
        yield return new WaitForSeconds(5);

        Destroy(gameObject);
    }
}
