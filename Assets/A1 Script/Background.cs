using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Sprite bg1;
    public Sprite bg2;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = bg1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        //sprite move at negative mouse position
        transform.position = new Vector3(-mousePosition.x, -mousePosition.y, 1f) * 0.02f;

        //changing sprite when clicked
        if (Input.GetMouseButtonDown(0))
        {
            if (spriteRenderer.sprite == bg1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = bg2;
                transform.localScale = new Vector3(0.55f, 0.55f, 1f);
            }
            else if (spriteRenderer.sprite == bg2)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = bg1;
                transform.localScale = new Vector3(0.55f, 0.55f, 1f);
            }
        }
    }
}
