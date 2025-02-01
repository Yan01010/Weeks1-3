using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float Speed = 100f;

    private bool isWhite = false;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //rotate around the deity
        transform.RotateAround(transform.parent.position, Vector3.forward, Speed * Time.deltaTime);

        //change colour on click
        if (Input.GetMouseButtonDown(0))
        {
            if (isWhite)
            {
                spriteRenderer.color = Color.black;
            }
            else
            {
                spriteRenderer.color = Color.white;
            }

            isWhite = !isWhite;
        }
    }
}
