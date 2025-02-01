using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Sprite MoonY;
    public Sprite MoonX;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = MoonX;
    }

    // Update is called once per frame
    void Update()
    {
        //rotating counter clockwise
        transform.Rotate(Vector3.forward * 5 * Time.deltaTime);

        //change sprite when click
        if (Input.GetMouseButtonDown(0))
        { 
            if (spriteRenderer.sprite == MoonX)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = MoonY;
            } else if (spriteRenderer.sprite == MoonY)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = MoonX;
            }


        }
    }
}
