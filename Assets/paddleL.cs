using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // translate up
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y <= 2.3)
            {
                transform.Translate(0f, 0.01f, 0f);
            }
        }
        // translate down
        else if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y >= -2.23)
            {
                transform.Translate(0f, -0.01f, 0f);
            }
        }
    }
}
