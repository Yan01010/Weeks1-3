using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twinkle : MonoBehaviour
{
    public float Speed;

    //opacity of the stars
    public float minOpacity = 0f;
    public float maxOpacity = 1f;

    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Speed = Random.Range(0.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //make the stars twinkle by increasing and decreasing opacity
        float alpha = Mathf.Lerp(minOpacity, maxOpacity, Mathf.PingPong(Time.time * Speed, 1f));
        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, alpha);
    }
}
