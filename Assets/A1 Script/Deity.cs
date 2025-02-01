using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoddessBehaviour : MonoBehaviour
{
    //start and end point for animation
    public Transform start;
    public Transform end;
    public AnimationCurve curve;

    //timer
    [Range(0, 1)]
    public float t = 0f;

    //check if moving downward
    private bool down = true;

    public Sprite DeityD;
    public Sprite DeityL;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = DeityD;
    }

    // Update is called once per frame
    void Update()
    {
        //up and down animation
        if (down)
        {
            t += Time.deltaTime * 0.5f;

            //when t reaches 1, reverse direction
            if (t >= 1f)
            {
                t = 1f;
                down = false;
            }
        }
        else
        {
            t -= Time.deltaTime;

            //when t reaches 0, reverse direction
            if (t <= 0f)
            {
                t = 0f;
                down = true;
            }
        }

        transform.position = Vector3.Lerp(start.position, end.position, curve.Evaluate(t));

        //changing sprite when clicked
        if (Input.GetMouseButtonDown(0))
        {
            if (spriteRenderer.sprite == DeityD)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = DeityL;
            }
            else if (spriteRenderer.sprite == DeityL)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = DeityD;
            }
        }
        }
}
