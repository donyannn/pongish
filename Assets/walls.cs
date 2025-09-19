using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walls : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Color randomColor = new Color(
                    Random.Range(0f, 1f), 
                    Random.Range(0f, 1f), 
                    Random.Range(0f, 1f), 
                    1f                    
                );

        spriteRenderer.color = randomColor;

    }
}
