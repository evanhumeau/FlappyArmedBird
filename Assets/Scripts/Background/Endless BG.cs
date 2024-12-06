using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessBG : MonoBehaviour
{
    [SerializeField] private float bgSpeed;
    [SerializeField] private float RightBgPos; //"RightBgPos value is the Position of the panel that is the most to the right (panel3), in case were changing his size"

    private Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x /2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * bgSpeed);

        if(transform.position.x < startPos.x - RightBgPos)
        {
            transform.position = startPos;
        }
    }
}
