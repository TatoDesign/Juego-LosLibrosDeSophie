using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinito : MonoBehaviour
{
    private float spritewidth;

    void Start()
    {
        BoxCollider2D tama�oCollider = GetComponent<BoxCollider2D>();
        spritewidth = tama�oCollider.size.x;
    }


    void Update()
    {
        if(transform.position.x < -spritewidth)
        {
            ResetPosition();
        }
    }

    private void ResetPosition()
    {
        transform.Translate(new Vector3(2 * spritewidth, 0f, 0f));
    }
}
